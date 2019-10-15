<template>
  <div id="app">
    <ul>
      <li v-for="context in contexts" v-bind:key="context.id">{{context}}</li>
    </ul>
    <div class="crud-display">
      <button v-on:click="loadContext()">Read</button>
      <input spellcheck="false" v-model="contexts.id" placeholder="Id to delete">
      <button v-on:click="deleteContext()">Delete</button>
      <input spellcheck="false" v-model="contexts.name" placeholder="Name to add">
      <input spellcheck="false" v-model="contexts.price" placeholder="Price to add">
      <button v-on:click="addContext()">Add</button>
      <input spellcheck="false" v-model="contexts.id" placeholder="Id to update">
      <input spellcheck="false" v-model="contexts.name" placeholder="Name to update">
      <input spellcheck="false" v-model="contexts.price" placeholder="Price to update">
      <button v-on:click="editContext()">Edit</button>
    </div>
  </div>
</template>

<script>
import axios from 'axios'
export default {
  name: 'app',
  data: () => {
    return {
      contexts: []
    }
  },
  methods: {
    loadContext: function() {
      axios.get('https://bastion-shop.azurewebsites.net/api/speakers').then(response => (this.contexts = response.data))
    },
    deleteContext: function() {
      if(confirm("Delete speaker of Id: " + this.contexts.id + "?")) 
      {
        axios.delete('http://world-of-oz.azurewebsites.net/api/colors/' + this.contexts.id)
      }
    },
    addContext: function () {
      axios.post('http://bastion-shop.azurewebsites.net/api/speakers', {
        name: this.contexts.name,
        price: this.contexts.price
      }).then(() => {
        alert("Speaker " + this.contexts.name + " added!");
      });
    },
    editContext: function () {
      axios.put('http://world-of-oz.azurewebsites.net/api/colors/' + this.contexts.id, {
        id: this.contexts.id,
        name: this.contexts.name,
        update: this.contexts.price
      }).then(() => {
        alert("Speaker " + this.contexts.id + ": " + this.contexts.name + " updated!");
      });
    }
  }
}
</script>

<style>
 .crud-display{
    display: block;
    font-size:11px;
    padding:4px 2px;
    border:solid 1px #aacfe4;
    width:150px;
    margin:2px 0 20px 10px;
}
</style>