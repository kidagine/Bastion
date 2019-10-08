<template>
  <div>
    <NavigationBar/>
    <h1 id="page-heading">SHOP</h1>
    <div id="main-container">
      <div id="buttons-container">
        <div id="button-container">
          <a id="button">Earbuds</a>
        </div>
        <div id="button-container">
          <a id="button">Headphones</a>
        </div>
        <div id="button-container">
          <a id="button">Speakers</a>
        </div>
      </div>
      <!-- <div id="sort-container">
      </div> -->
      <main id="products-container">
        <div id="product-grid">
          <ul>
            <li v-for="product in products" v-bind:key="product.d"> {{product.id}} {{product.name}} {{product.price}} </li> 
          </ul>
        </div>
      </main>
    </div>
  </div>
</template>

<script>
import NavigationBar from '../components/NavigationBar.vue'
import axios from 'axios';
  export default {
    mounted() {
      this.fetchProducts()
    },
    data: ()  => ({
      products: []
    }),
    components: {
      NavigationBar
    },
    methods: {
      fetchProducts() {
        axios.get('http://bastion-shop.azurewebsites.net/api/speakers/')
          .then((data) => {
            this.products = data.data;
          });
        }
    }
  };
</script>

<style>
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
    font-family: HelveticaNeueW02-75Bold,HelveticaNeueBold,HelveticaNeue-Bold,"Helvetica Neue Bold",HelveticaNeue,"Helvetica Neue",TeXGyreHerosBold,Helvetica,Tahoma,Geneva,Arial,sans-serif;
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