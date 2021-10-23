import Vue from 'vue'
import Router from 'vue-router'
import ResultMatch from '@/components/ResultMatch/ResultMatch'
import Homepage from '@/components/Homepage/Homepage'

Vue.use(Router)

export default new Router({
    routes: [
        {
            path: '/',
            component: Homepage
        },
        {
            path: '/result',
            component: ResultMatch
        },
        
    ]
})