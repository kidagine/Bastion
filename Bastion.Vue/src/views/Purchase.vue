<template>
  <div>
    <NavigationBar/>

    <header class="overview container">
        <div class="fullscreen-video-wrap">
          <img v-bind:src="product.background" >
        </div>
        <div class="header-content text-md-center">
            <h1>DEEPER DIMENSIONS OF SOUND.</h1>
            <p class="name">{{product.name}}</p>
            <p class="price">{{product.price}}€</p>
            <div class="button-container">
              <router-link :to="`/checkout/${product.id}`">
              <a id="button">Purchase</a>
              </router-link>
            </div>
        </div>
    </header>
    <Footer/>
  </div>
</template>

<script>
import axios from 'axios';
import NavigationBar from '../components/NavigationBar.vue'
import Footer from '../components/Footer.vue'
  export default {
    mounted() {
      this.fetchProducts(this.$route.params.id);
    },
    data: ()  => ({
      product: ''
    }),
    components: {
      NavigationBar,
      Footer
    },
    methods: {
    fetchProducts(id) {
      axios.get('http://bastion-shop.azurewebsites.net/api/speakers/' + id)
        .then((data) => {
          this.product = data.data;
        });
      }
    }
  };
</script>

<style>
/* Overview Start */
.overview{
    height:100vh;
    display:flex;
    align-items:center;
    color:#fff;
}

.container{
    max-width:1470px;
    padding-left:1rem;
    padding-right:55rem;
    margin:auto;
    text-align:center;
}
  
.fullscreen-video-wrap{
    position:absolute;
    top:0;
    left:0;
    width:100%;
    height:100vh;
    overflow:hidden;
}
  
.fullscreen-video-wrap img{
    min-height:100%;
    min-width:100%;
}
  
.header-content{
    z-index:2;
}
  
.header-content h1{
  font-family: sans-serif; 
  text-align: left;
  line-height: 85%;
  font-weight: 800;
  font-size: 55px;
  margin-bottom:10px;
}
  
.name{
  font-family: sans-serif; 
  text-align: left;
  line-height: 85%;
  font-weight: 800;
  font-size: 27px;
  margin-bottom:10px;
}

.price{
  font-family: sans-serif; 
  text-align: left;
  line-height: 85%;
  font-weight: bold;
  font-size: 20px;
  padding-bottom: 10px;
  margin-bottom:20px;
  border-bottom: 2px solid #fff;

}
.button-container{
    width: 200px;
    height: 500px;

}
/* Overview End */
</style>