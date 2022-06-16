<template>
  <div>
    <HeaderComponent></HeaderComponent>
    <LoginBoxComponent></LoginBoxComponent>
    <FooterComponent></FooterComponent>
  </div>
</template>

<script>
import $ from 'jquery'
import HeaderComponent from "../components/HeaderComponent";
import LoginBoxComponent from "../components/LoginBox/LoginBoxComponent";
import FooterComponent from "../components/FooterComponent";
export default {
  name: "LoginComponent",
  components: {FooterComponent, LoginBoxComponent, HeaderComponent},
  mounted() {
    $(".hp-menu").css("display","none");
  }
}
</script>

<style scoped>

</style>