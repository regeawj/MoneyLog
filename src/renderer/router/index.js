import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

export default new Router({
    routes: [
        {
            path: '/intro',
            name: 'intro',
            component: require('@/components/IntroView/IntroView').default
        },
        {
            path: '/todo',
            name: 'todo-view',
            component: require('@/components/ToDoView').default
        },
        {
            path: '*',
            redirect: '/'
        }
    ]
})
