import Vue from 'vue';
import Router from 'vue-router';
import Home from "./views/Home.vue";
import Shop from "./views/Shop.vue";
import ShopHeadphones from "./views/shop-categories/Headphones.vue";
import ShopEarbuds from "./views/shop-categories/Earbuds.vue";
import ShopSpeakers from "./views/shop-categories/Speakers.vue";
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
      path: '/shop/earbuds',
      name: 'earbuds',
      component: ShopEarbuds
    },
    {
      path: '/shop/headphones',
      name: 'headphones',
      component: ShopHeadphones
    },
    {
      path: '/shop/speakers',
      name: 'speakers',
      component: ShopSpeakers
    },
    {
      path: '/purchase/:id',
      name: 'purchase',
      component: Purchase
    },
    {
      path: '/checkout/:id',
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