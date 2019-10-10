<template>
<div>
  <div id="header">
    <div id="inner_header">
      <div id="logo_container">
        <router-link to = '/'>
          <div id="logo">BASTION</div>
        </router-link>
      </div>
      <ul id="navigation">
          <a href="/shop/"><li>SHOP</li></a>
      </ul>

      <ul id="external">
          <a><li><img src="../../src/assets/search-icon.png" width="26" height="26"></li></a>
          <router-link to="/checkout">
          <a><li><img src='../../src/assets/basket.png' width="26" height="26"></li></a>
          </router-link>
      </ul>
    </div>
  </div>

</div>
</template>

<style>
input[type=text] {
  width: 130px;
  -webkit-transition: width 0.4s ease-in-out;
  transition: width 0.4s ease-in-out;
}

/* When the input field gets focus, change its width to 100% */
input[type=text]:focus {
  width: 100%;
}
  /* Header Start */
  #header{
      width: 100% ;
      height: 61px;
      top: 0px;
      display: block;
      background-color: #000;
      position: fixed;
      z-index: 10;
  }

  #inner_header{
      width:1560px;
      height: 100%;  
      display: block;
      margin: 0 auto;
      padding: 0px 60px;
  }

  #logo_container{
      height: 100%;
      display: table;
      float: left;
  }

  #logo{
    padding-top: 10px;
    box-sizing: border-box;
    vertical-align: middle;
    font-weight: bold;
    font-size: 28px;
    color: white;
  }

  #navigation{
    float: left;
    height: 100%;
  }

  #navigation a{
    height: 100%;
    font-weight: bold;
    display: table;
    float: left;
    padding-right: 30px;
  }

  #navigation a:first-child{
      padding-left: 35px;
  }

  #navigation a li{
      display: table-cell;
      vertical-align: middle;
      height: 100%;
      color: #fff;
      font-size: 13px;
      position: relative;
      text-decoration: none;
  }

  #navigation a li:hover{
      color: #9a9a9a;
  }

  #navigation a li::before{
      content: "";
      position: absolute;
      width: 100%;
      height: 2px;
      bottom: 12px;
      left: 0;
      background-color: #fff;
      visibility: hidden;
      -webkit-transform: scaleX(0);
      transform: scaleX(0);
      -webkit-transition: all 0.3s ease-in-out 0s;
      transition: all 0.3s ease-in-out 0s;
  }

  #navigation a li:hover::before{
      visibility: visible;
      -webkit-transform: scaleX(1);
      transform: scaleX(1);
  }

  #external{
      float: right;
      height: 100%;
  }

  #external a{
      height: 100%;
      display: table;
      float: left;
      padding-right: 25px;
  }

  #external a:last-child{
      padding-right: 0;
  }

  #external a li{
      display: table-cell;
      vertical-align: middle;
      height: 100%;
  }
  /* Header End */
</style>