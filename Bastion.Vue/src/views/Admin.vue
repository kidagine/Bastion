<template>
  <div>
    <h1>
      Admin
    </h1>
    <div class="crud-container">
      <div class="post-container">
            <button id="button">Post</button>
              <input type="text" placeholder="Name">
              <input type="text" placeholder="Price">
      </div>
      <div class="delete-container">
            <button id="button" >Delete</button>
            <input type="text" placeholder="Id to delete">
      </div>
      <div class="put-container">
            <button id="button">Update</button>
            <input type="text" placeholder="Name">
            <input type="text" placeholder="Price">
      </div>
    </div>
          <button id="button" v-on:click="getAllProducts">Read All</button>
        <button id="button" v-on:click="getProduct">Read by id</button>
    <ul class="admin-product-list" v-for="product in products" :key="product.id">
      <h2 class="admin-product-list-item">
        {{ product.id }}  {{ product.name }} {{ product.price }}
      </h2>
    </ul> 
    <h3>
      {{ product.id }} {{product.name}} {{product.price}}
    </h3>
  </div>
</template>

<script>
import NavigationBar from '../components/NavigationBar.vue'
import axios from 'axios';
  export default {
    mounted() {
      this.deleteProduct();
    },
    data: ()  => ({
      products: [],
      product: ''
    }),
    components: {
      NavigationBar
    },
    methods: {
      getAllProducts() {
        axios.get('http://bastion-shop.azurewebsites.net/api/speakers/')
          .then((data) => {
            this.products = data.data;
          });
        },
      getProduct() {
      axios.get('http://bastion-shop.azurewebsites.net/api/speakers/1')
        .then((data) => {
          this.product = data.data;
        });
      },
      deleteProduct() {
      axios.delete('http://bastion-shop.azurewebsites.net/api/speakers/1')
      
      }
    }
  };
</script>
<style>
.crud-container{
  padding-top: 5%;
    width: 100%;
    font-size: 12px;
    overflow: hidden; /* contain floated elements */
    background: #ccc
}
.post-container{
  background-color: red;
    float: left; 
    width: 33.3%;
    padding-right: 1%;
    padding-left: 1%;}
.delete-container{
    background-color: red;
    float: left; 
    width: 33.3%;
    padding-right: 1%;
    padding-left: 1%;
}
.put-container{
    background-color: red;
    float: left; 
    width: 33.3%;
    padding-right: 1%;
    padding-left: 1%;
}


.admin-product-list {
  list-style: none;
  margin: 20px auto;
  width: 50%;
}

.admin-product-list-item {
  border: 1px solid rgb(41, 41, 41);
  border-radius: 5px;
  text-align: center;
  display: block;
  box-shadow: 2px 2px rgba(138, 124, 124, 0.4);
}
#button{
  overflow: hidden;
  height: 3.57143rem;
  line-height: 3.57143rem;
  transition: all .15s ease;
  font-family: "Helvetica Neue";
  letter-spacing: .07143rem;
  font-size: .85714rem;
  text-transform: uppercase;
  text-align: center;
  background: 0 0;
  color: #000;
  background: #ededed;
  z-index: 9;
  width: 100%;
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
#button:after {
  content: "";
  background: #e4007c;
  display: block;
  position: absolute;
  padding-top: 300%;
  padding-left: 350%;
  margin-left: -20px!important;
  margin-top: -120%;
  opacity: 0;
  transition: all 0.8s
}
#button:active:after {
  padding: 0;
  margin: 0;
  opacity: 1;
  transition: 0s
}
</style>