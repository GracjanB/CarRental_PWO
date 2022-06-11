import Vue from 'vue'
import VueRouter from 'vue-router'
import HomepageComponent from "../views/HomepageComponent";
import DashboardComponent from "../views/DashboardComponent";

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Homepage',
    component: HomepageComponent
  },
  {
    path: '/dashboard',
    name: 'Dashboard',
    component: DashboardComponent
  },
]

const router = new VueRouter({
  routes
})

export default router
