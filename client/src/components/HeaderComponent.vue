<template>
<div>
  <div class="container nonbgs">
    <b-navbar>
      <template #brand>
        <b-navbar-item tag="router-link" :to="{ path: '/' }">
          <img
              :src="logo"
              alt="Rider"
          >
        </b-navbar-item>
      </template>
      <template #start>
        <b-navbar-item tag="router-link" :to="{ path: '/' }" class="noshow-menu">
          <a href="#" ><span>Strona główna</span></a>
        </b-navbar-item>
        <b-navbar-item class="hp-menu">
          <a href="#" v-scroll-to="'#ABOUTUS'"><span>O nas</span></a>
        </b-navbar-item>
        <b-navbar-item href="#Location" class="hp-menu">
          <a href="#" v-scroll-to="'#LOCATIONS'"><span>Lokalizacje</span></a>
        </b-navbar-item>
        <b-navbar-item href="#Pricer" class="hp-menu">
          <a href="#" v-scroll-to="'#PRICER'"><span>Cennik</span></a>
        </b-navbar-item>
        <b-navbar-item class="hp-menu">
          <a href="#" v-scroll-to="'#CONTACT'"><span>Kontakt</span></a>
        </b-navbar-item>

      </template>

      <template #end>
        <b-navbar-item tag="div">
        </b-navbar-item>
      </template>
    </b-navbar>
  </div>
</div>
</template>

<script>
// import $ from 'jquery';
export default {
  name: "HeaderComponent",
  data: function (){
    return{
      logo: 'logo.png',
      islogin: 0,
    }
  },
  methods:{
    checkLogin:function ()
    {
      var cookie_login = (document.cookie.match(/^(?:.*;)?\s*loginid\s*=\s*([^;]+)(?:.*)?$/)||[null])[1];
      console.log("COOKIE");
      console.log(cookie_login);
      if(cookie_login!=null && cookie_login!="")
      {
        location.replace("#/dashboard");
        this.islogin = 1;
      }
      else
      {
        if (window.location.href.indexOf("dashboard") != -1)
          location.replace('/F');
      }
    },
    logout:function ()
    {
      document.cookie ="loginid= ; expires = Thu, 01 Jan 1970 00:00:00 GMT";
      document.cookie ="loginname= ; expires = Thu, 01 Jan 1970 00:00:00 GMT";
      document.cookie ="logintoken= ; expires = Thu, 01 Jan 1970 00:00:00 GMT";
      location.reload();
    }
  },
  mounted() {
    this.checkLogin();
  }

}
</script>

<style scoped>

</style>