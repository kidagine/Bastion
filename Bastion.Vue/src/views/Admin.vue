<template>
  <div id="app">
    <ul>
      <li v-for="context in contexts" v-bind:key="context.id">{{context}}</li>
    </ul>
    <button v-on:click="loadContext()">Load</button>
    <input v-model="del">
    <button v-on:click="deleteContext()">Delete</button>
    <button v-on:click="addContext()">Add</button>
    <button v-on:click="editContext()">Edit</button>
  </div>
</template>

<script>
import axios from 'axios'
export default {
  name: 'app',
  //mounted() {
  //  this.loadContent()
  //},
  data: () => {
    return {
      del: "",
      contexts: [],
      rubberDuck: {
        "id": 16,
        "duckColor": { "id": 1, "name": "Yellow" },
        "duckPattern": { "id": 1, "name": "Spotted" },
        "duckSize": 3,
        "price": 678,
        "duckGender": 1,
        "duckCostume": { "id": 1, "name": "Navy" }
      },
      editRubberDuck: {
        "id": 16,
        "duckColor": { "id": 1, "name": "Yellow" },
        "duckPattern": { "id": 1, "name": "Spotted" },
        "duckSize": 3,
        "price": 100,
        "duckGender": 1,
        "duckCostume": { "id": 1, "name": "Navy" }
      }
    }
  },
  methods: {
    loadContext: function() {
      axios.get('http://bastion-shop.azurewebsites.net/api/speakers/').then(response => (this.contexts = response.data))
    },
    deleteContext: function() {
      axios.delete('http://bastion-shop.azurewebsites.net/api/speakers/' + this.del)
    },
    addContext: function () {
      axios.post('http://bastion-shop.azurewebsites.net/api/speakers/', this.rubberDuck)
    },
    editContext: function () {
      axios.put('https://rubberduckshop.azurewebsites.net/api/duck/16', this.editRubberDuck)
    }
  }
}
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