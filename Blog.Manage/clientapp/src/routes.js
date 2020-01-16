import Login from './views/Login';
import Home from './views/Home.vue'

import Article from './views/articles';


const routes = [
    {
        path: '/login',
        component: Login,
        name: '',
        hidden: true
    },
    {
        path: '/',
        component: Home,
        name: '',
        iconCls: 'el-icon-notebook-2',//图标样式class
        children: [
            { path: '/article', component: Article, name: 'Article' }
        ]
    },
];

export default routes;