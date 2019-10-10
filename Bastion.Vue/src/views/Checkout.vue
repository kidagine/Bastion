<template>
<div>
  <div id="header-checkout">
    <div id="inner_header-checkout">
      <div id="logo_container-checkout">
        <router-link to = '/'>
          <div id="logo-checkout">BASTION</div>
        </router-link>
      </div>
      <div id="text_container-checkout">
          <div id="text-checkout">CHECKOUT</div>
      </div>
    </div>
  </div>
    <div class="checkout-container" >
      <div class="order-details-container"> 
        <div class="product-list-item">
            <router-link :to="`/purchase/${product.id}`">
            <img v-bind:src="product.image" width="160" height="160" >
            </router-link >
            <h1>
              <span>{{ product.name }}</span> <br> <span>{{ product.price }}€</span>
            </h1>
        </div>  
      </div>
      <div class="order-summary-container"> 
            <div class="order">
              <p>
                ORDER SUMMARY
              </p>  
              <div class="order-details">
                <p>
                  Subtotal: {{product.price}}€ <br>
                  Shipping: -- <br>
                  Total: {{product.price}}€ <br>
                  <span>
                  Change payment method
                  </span>
                </p>
              </div>
              <div class="order-text">
                <p>
                  By Selecting [Order & Pay], you request <br>
                  immediate access to your purchase with the <br>
                  understanding that you will not have a <br>
                  "cooling off period" during which you can <br>
                  cancel your purchase.
                </p>
              </div>
                <button>
                  Order & Pay
                </button>
            </div>
         </div>
    </div>
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
.checkout-container{
  padding-top: 5%;
  width: 60%;
  margin: 0 auto;
  overflow: hidden;
}

.order-details-container{
  border-left: 2px solid #000;
  padding-left: 1%;
  width: 700px; 
  height: 580px;
  float: left;
}

.order-summary-container{
  padding-right: 1%;
  margin-left: 720px;
  height: 500px;
}

  /* Order Start */

#order-container{
  background: red;
  width: 30%;
  height:560px;
  margin: 0 auto;
  margin-top: 7%;
  border-left: 2px solid #000;
  margin-bottom: 5%;
  background-size:25px 25px;
}


.order{
  background-color: #fff;
  border-color: #ddd;
  box-shadow: 0 1px 4px rgba(221,221,221,.6);
  width:100%;
  height:100%;
  z-index: 2;
}
.order p{
  font-family: 'Montserrat';
  text-align: left;
  padding-left: 5%;
  padding-top: 5%;
  padding-bottom: 5%; 
  font-weight: 700;
  font-size: 22px;
  border-bottom: 1px solid rgba(221,221,221,.6);
}
.order button{
    font-family: 'Montserrat';
    font-weight: 500;
  margin-top: 0%;
    height: 17%;
    line-height: 3.57143rem;
    transition: all .15s ease;
    white-space: nowrap;
    text-align: center;
    color: #000;
    background: #ededed;
    width: 100%;
        display: block;
     -o-transition:.5s;
    -ms-transition:.5s;
    -moz-transition:.5s;
    -webkit-transition:.5s;
    transition:.5s;
}
.order button:hover{
    background-color: black;
    color:white;
    cursor: pointer;   
}
.order-details p{
  padding-top: 2%;
  font-weight: 300;
  font-size: 18px;
  line-height: 200%;

}
.order-details span{
  text-align: right;
  font-size: 20px;
  color:blue;
  cursor:pointer;
}
.order-text p{
  padding-top: 2%;
  font-weight: 300;
  font-size: 18px;
  line-height: 150%;
  border-bottom: hidden;
}
  /* Order End */
  /* Header Start */
  #header-checkout{
      width: 100% ;
      height: 96px;
      top: 0px;
      display: block;
      background-color: #000;
      position: fixed;
      z-index: 10;
  }

  #inner_header-checkout{
      width:1260px;
      height: 100%;  
      display: block;
      margin: 0 auto;
      padding: 0px 60px;
  }

  #logo_container-checkout{
      height: 100%;
      display: table;
      float: left;
  }

  #logo-checkout{
    padding-top: 20px;
    box-sizing: border-box;
    vertical-align: middle;
    font-weight: bold;
    font-size: 36px;
    color: white;
  }

  #text_container-checkout{
      height: 100%;
      display: table;
      float: right;
  }

  #text-checkout{
    padding-top: 20px;
    box-sizing: border-box;
    vertical-align: middle;
    font-weight: bold;
    font-size: 36px;
    color: white;
  }


  /* Header End */
</style>