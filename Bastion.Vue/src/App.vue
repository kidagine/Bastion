<template>
  <div id="app">
    <div id="nav">
    </div>
    <router-view/>
  </div>
</template>

<script>
import Footer from './components/Footer.vue'

export default {
  components: {
    Footer
  }
}
</script>

<style>
  #app {
    font-family: 'Montserrat';
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: black;
    margin-top: 60px;
  }
  /* General Start */
  *{
    margin: 0;
    padding: 0;
    list-style: none;
    text-decoration: none;
  }

  html{
    scroll-behavior: smooth;
  }

  body{
    background-color: white;
    overflow-x: hidden;
  }
  /* General End */
</style>

