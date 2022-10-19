'use strict'

import {app, BrowserWindow, ipcMain, Menu, Tray, shell} from 'electron'

import {autoUpdater} from 'electron-updater'


let appTray = null

let trayClose = false
/**
 * Set `__static` path to static files in production
 
 */
if (process.env.NODE_ENV !== 'development') {
    global.__static = require('path').join(__dirname, '/static').replace(/\\/g, '\\\\')
}

let mainWindow
const winURL = process.env.NODE_ENV === 'development'
    ? `http://localhost:9080`
    : `file://${__dirname}/index.html`

function createWindow() {
    /**
     * Initial window options
     */
    mainWindow = new BrowserWindow({
        height: 840,
        useContentSize: true,
        width: 1080
    })

    mainWindow.loadURL(winURL)

    if (process.env.NODE_ENV === 'development') {
        mainWindow.webContents.openDevTools()
    }
    mainWindow.on('close', (event) => {
        if (!trayClose) {
            // 最小化
            mainWindow.hide()
            event.preventDefault()
        }
    })

    mainWindow.on('closed', () => {
        mainWindow = null
    })

   
    mainWindow.once('ready-to-show', () => {
        mainWindow.show()
    })

    const trayMenuTemplate = [
        {
            label: 'About',
            click: function () {
           
                shell.openExternal('http://www.google.com')
            }
        },
        {
            label: 'Exit',
            click: function () {
                
                trayClose = true
                app.quit()
            }
        }
    ]
   
    const path = require('path')
    const iconPath = path.join(__dirname, '/static/icon2.ico')
    appTray = new Tray(iconPath)
   
    const contextMenu = Menu.buildFromTemplate(trayMenuTemplate)
  
    appTray.setToolTip('')
    
    appTray.setContextMenu(contextMenu)
   
    appTray.on('click', () => {
        mainWindow.isVisible() ? mainWindow.hide() : mainWindow.show()
    })
}

app.on('ready', createWindow)

app.on('window-all-closed', () => {
    if (process.platform !== 'darwin') {
        app.quit()
    }
})

app.on('activate', () => {
    if (mainWindow === null) {
        createWindow()
    }
})

/**
 * Auto Updater
 *
 * Uncomment the following code below and install `electron-updater` to
 * support auto updating. Code Signing with a valid certificate is required.
 * 

function sendUpdateMessage(text) {
    mainWindow.webContents.send('message', text)
}


let message = { // eslint-disable-line no-unused-vars
    error: 'An error occured during updating',
    checking: 'Updating......',
    updateAva: 'Downloading new version......',
    updateNotAva: 'This is the latest version'
}

const os = require('os') // eslint-disable-line no-unused-vars

// An error occured during updating
autoUpdater.on('error', (err) => {
    sendUpdateMessage('error')
})
// Updating
autoUpdater.on('checking-for-update', () => {
    sendUpdateMessage('checking')
})
// auto updator, downloading
autoUpdater.autoDownload = false
autoUpdater.on('update-available', (info) => {
    sendUpdateMessage('updateAva')
})
// update not available
autoUpdater.on('update-not-available', (info) => {
    sendUpdateMessage('updateNotAva')
})
// download progress
autoUpdater.on('download-progress', (progressObj) => {
    mainWindow.webContents.send('downloadProgress', progressObj)
})
/**
 * event Event
 * releaseNotes String 
 * releaseName String 
 * releaseDate Date 
 * updateUrl String 
 */
autoUpdater.on('update-downloaded', (info) => {
    ipcMain.on('isUpdateNow', (e, arg) => {
        // some code here to handle event
        autoUpdater.quitAndInstall()
    })
    mainWindow.webContents.send('isUpdateNow')
})

ipcMain.on('checkForUpdate', () => {
    
    autoUpdater.checkForUpdates()
})

ipcMain.on('downloadUpdate', () => {
   
    autoUpdater.downloadUpdate()
})
