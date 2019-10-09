import Vue from 'vue';
import Router from 'vue-router';
import Home from "./views/Home.vue";
import Shop from "./views/Shop.vue";
import Purchase from "./views/Purchase.vue";
import Checkout from "./views/Checkout.vue";
import Admin from "./views/Admin.vue";

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: "/",
      name: "home",
      component: Home
    },

    {
      path: '/shop/',
      name: 'shop',
      component: Shop
    },
    {
      path: '/purchase/',
      name: 'purchase',
      component: Purchase
    },
    {
      path: '/checkout/',
      name: 'checkout',
      component: Checkout
    },
    {
      path: "/admin/",
      name: "admin",
      component: Admin
    },
  ]
})