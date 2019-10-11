<template>
  <div>
    <NavigationBar/>
    <header class="overview container">
        <div class="fullscreen-video-wrap">
          <img src="https://i.imgur.com/0tFKFa7.png">
        </div>
        <div class="header-overlay"></div>
          <div class="header-content text-md-center">
            <h1>HEAR BEYOND THE SURFACE.</h1>
            <router-link :to="`/shop/`">
                    <button id="button-enter">SHOP NOW</button>
            </router-link>
          </div>
    </header>
          <Footer/>
  </div>
</template>

<script>
import NavigationBar from '../components/NavigationBar.vue'
import Footer from '../components/Footer.vue'
  export default {
    components: {
      NavigationBar,
      Footer
    },
  };
</script>

<style> 
  #button-enter{
    overflow: hidden;
    height: 70px;
    transition: all .15s ease;
    font-family: "Helvetica Neue";
    letter-spacing: .07143rem;
    font-size: .85714rem;
    text-transform: uppercase;
    font-size: 15px;
    padding: 0 2.85714rem;
    border: 0;
    margin: 0 auto; 
    white-space: nowrap;
    text-align: center;
    background: 0 0;
    color: #000;
    background: #dedede;
    z-index: 9;
    width: 23%;
    display: block;
    outline: 2px solid #ededed;
    outline-offset: 8px;
  }
  #button-enter:hover{
    background-color: white;
    cursor: pointer;  
    border: 1px solid #dedede;
  outline-color: rgba(0, 0, 0, 0);
  outline-offset: 15px;  
  }
/* Overview Start */
.overview{
    height:100vh;
    display:flex;
    align-items:center;
    color:#fff;
}

.overview h1 {
  padding-bottom: 5%;
}
  
.container{
    max-width:960px;
    padding-left:1rem;
    padding-right:1rem;
    margin:auto;
    text-align:center;
}

.box{
    padding-top: 25px;
    padding-right: 50px;
    padding-left: 50px;
    background: #000;
    border: 3px solid #fff;
    opacity: 0.95;
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
  
.header-overlay{
    height:100vh;
    position: absolute;
    top:0;
    left:0;
    width:100vw;
    z-index:1;
    background:#000;
    opacity:0.3;
}
/* Overview End */
</style>