<template>
  <div>
    <button id="button" v-on:click="postProduct">Post</button>
    <button id="button" v-on:click="deleteProduct">Delete</button>
    <input type="text" v-model="name">
    <button id="button" v-on:click="getAllProducts">Read All</button>
    <button id="button" v-on:click="getIdProduct">Read Id</button>
    <ul class="admin-product-list" v-for="product in products" :key="product.id">
      <h2 class="admin-product-list-item">
        {{ product.id }}  {{ product.name }} {{ product.price }}
      </h2>
    </ul> 
  </div>
</template>

<script>
import axios from 'axios';
  export default {
    mounted() {
    },
    data: ()  => ({
      products: []
    }),
    methods: {
      getAllProducts() {
        axios.get('https://jsonplaceholder.typicode.com/posts')
          .then((data) => {
            this.products = data.data;
          });
        },
      getIdProduct() {
        axios.get('https://jsonplaceholder.typicode.com/posts/1')
          .then((data) => {
                        console.log(data.data)

                        this.products = data.data;
            console.log(data.data);
          })
      },
      deleteProduct() {
      axios.delete('https://jsonplaceholder.typicode.com/users/1')
        .then((data) => {
                      console.log(data.data);

                      this.products.pop(data.data);
          console.log(data.data);
        })
      },
      postProduct() {
      axios.post('https://jsonplaceholder.typicode.com/users/') 
      .then((data) => {
                      console.log(data.data);

                      this.products.push(data.data);
          console.log(data.data);
      })
      }
    }
  };
</script>

<style>
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