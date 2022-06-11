import Vue from 'vue'
import VueRouter from 'vue-router'
import HomepageComponent from "../views/HomepageComponent";
import DashboardComponent from "../views/DashboardComponent";
import LoginComponent from "../views/LoginComponent";
import RegisterComponent from "../views/RegisterComponent";

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Homepage',
    component: HomepageComponent
  },
  {
    path: '/login',
    name: 'Login',
    component: LoginComponent
  },
  {
    path: '/register',
    name: 'Register',
    component: RegisterComponent
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
