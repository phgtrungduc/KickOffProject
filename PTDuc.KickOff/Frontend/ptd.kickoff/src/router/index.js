import Vue from 'vue'
import Router from 'vue-router'
import ResultMatch from '@/components/ResultMatch/ResultMatch'
import Homepage from '@/components/Homepage/Homepage'
import NotFound from '@/components/NotFound/NotFound'

Vue.use(Router)

export default new Router({
    mode: 'history',
    routes: [
        {
            path: '/',
            component: Homepage
        },
        {
            path: '/result',
            component: ResultMatch
        },
        {
            path: '*',
            component: NotFound
        },
        
    ]
})