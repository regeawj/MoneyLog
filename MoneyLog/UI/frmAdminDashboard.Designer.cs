﻿namespace MoneyLog
{
    partial class frmAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblAppFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblSHead = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Teal;
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 385);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1192, 31);
            this.pnlFooter.TabIndex = 0;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(485, 5);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(159, 17);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "Developed By: Bing, Lei, Li";
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1192, 24);
            this.menuStripTop.TabIndex = 1;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.categoryToolStripMenuItem.Text = "Accounting Detail";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.productsToolStripMenuItem.Text = "Catalog";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionToolStripMenuItem.Text = "Transactions";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(13, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User: ";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblLoggedInUser.Location = new System.Drawing.Point(47, 38);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(0, 17);
            this.lblLoggedInUser.TabIndex = 3;
            // 
            // lblAppFName
            // 
            this.lblAppFName.AutoSize = true;
            this.lblAppFName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFName.Location = new System.Drawing.Point(481, 196);
            this.lblAppFName.Name = "lblAppFName";
            this.lblAppFName.Size = new System.Drawing.Size(99, 37);
            this.lblAppFName.TabIndex = 4;
            this.lblAppFName.Text = "Money";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(569, 196);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(65, 37);
            this.lblLName.TabIndex = 5;
            this.lblLName.Text = "Log";
            // 
            // lblSHead
            // 
            this.lblSHead.AutoSize = true;
            this.lblSHead.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHead.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblSHead.Location = new System.Drawing.Point(446, 233);
            this.lblSHead.Name = "lblSHead";
            this.lblSHead.Size = new System.Drawing.Size(230, 25);
            this.lblSHead.TabIndex = 6;
            this.lblSHead.Text = "Accounting Management";
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 416);
            this.Controls.Add(this.lblSHead);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblAppFName);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblAppFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblSHead;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
    }
}

