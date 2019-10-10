<template>
  <div>
    <NavigationBar/>
    <h1 id="page-heading">SHOP</h1>
    <div id="main-container">
      <div id="buttons-container">
        <div id="button-container">
          <router-link to = '/shop/earbuds/'>
          <a id="button">Earbuds</a>
          </router-link>
        </div>
        <div id="button-container">
          <router-link to = '/shop/headphones/'>
          <a id="button">Headphones</a>
          </router-link>
        </div>
        <div id="button-container">
          <router-link to = '/shop/speakers/'>
          <a id="button">Speakers</a>
          </router-link>
        </div>
      </div>
      <!-- <div id="sort-container">
      </div> -->
      <div class="wrapper">
        <ul class="product-list" v-for="product in products" :key="product.id">
          <div class="product-list-item">
            <router-link :to="`/purchase/${product.id}`">
            <img v-bind:src="product.image" width="460" height="460" >
            </router-link>
            <h1>
              {{ product.name }} <br> {{ product.price }}
            </h1>
          </div>
        </ul>
      </div>
    </div>
  </div>
</template>

<script>
import NavigationBar from '../../components/NavigationBar.vue'
import axios from 'axios';
  export default {
    mounted() {
      this.fetchProducts();
    },
    data: ()  => ({
      products: [],
    }),
    components: {
      NavigationBar
    },
    methods: {
      fetchProducts() {
        axios.get('http://bastion-shop.azurewebsites.net/api/speakers/?SpeakerType=3')
          .then((data) => {
            this.products = data.data;
          });
        }
    }
  };
</script>

<style>
.wrapper {
  display: grid;
  grid-template-columns: 470px 470px 470px;
  grid-gap: 20px;
  margin-bottom:100px;
}

.box {
  font-size: 150%;
}
.product-list {
  list-style: none;
  display: flex;
  margin: 20px auto;
  width: 50%;
}

.product-list-item h1 {
  padding-top: 60px;
  font-family: 'Montserrat';
  font-size: 14px;
  font-weight:500;
  text-align: center;
}

.product-list-item img{
    transform: scale(1.5);
  transition: transform .2s;
}

.product-list-item img:hover {
  transform: scale(1.525);
  cursor:pointer;
}

  #page-heading{
    margin: 0;
    font-weight:700;
    font-size: 50px;;   
    text-align: center;
    font-family:'Montserrat';
    padding: 60px;
  }
  #main-container{
    max-width: 1560px;
    padding-left: 60px;
    padding-right: 60px;
    position: relative;
    margin-left: auto;
    margin-right: auto;
  }
  #buttons-container{
    max-width: none;
    margin-left: -.71429rem;
    margin-right: -.71429rem;
    margin-bottom: 10%; 
    width: auto;
    display: -webkit-box;
    flex-grow: 1;
  }
  #button-container{
    width: auto;
    min-width: 0;
    max-width: 100%;
    margin-bottom: 0;
    -webkit-box-flex: 1;
    -ms-flex-positive: 1;
    flex-grow: 1;
    -ms-flex-negative: 1;
    flex-shrink: 1;
    padding: 0 .85714rem 0 .71429rem;
  }
  #button{
    position: relative;
    overflow: hidden;
    height: 3.57143rem;
    line-height: 3.57143rem;
    transition: all .15s ease;
    font-family: "Helvetica Neue";
    letter-spacing: .07143rem;
    font-size: .85714rem;
    text-transform: uppercase;
    padding: 0 2.85714rem;
    border: 0;
    white-space: nowrap;
    text-align: center;
    background: 0 0;
    color: #000;
    background: #ededed;
    z-index: 9;
    width: 100%;
    display: block;
     -o-transition:.5s;
    -ms-transition:.5s;
    -moz-transition:.5s;
    -webkit-transition:.5s;
    transition:.5s;
  }
  #button:hover{
    background-color: black;
    color:white;
    cursor: pointer;    
  }
  #sort-container{
    width: auto;
    min-width: 245px;
    padding: 0;
    border-bottom: 1px solid #949494;
    display: block;
    box-sizing: border-box;
  }
  #products-container{
    display: block;
    box-sizing: border-box;
  }
  #product-grid{
   padding:10px;
   padding-bottom:60px;
  }
</style>