<template>
  <div>
    <HeaderComponent></HeaderComponent>
    <RegisterBoxComponent></RegisterBoxComponent>
    <FooterComponent></FooterComponent>
  </div>
</template>

<script>
import $ from 'jquery'
import HeaderComponent from "../components/HeaderComponent";
import FooterComponent from "../components/FooterComponent";
import RegisterBoxComponent from "../components/RegisterBox/RegisterBoxComponent";
export default {
  name: "RegisterComponent",
  components: {FooterComponent, RegisterBoxComponent, HeaderComponent},
  mounted() {
    $(".hp-menu").css("display","none");
  }
}
</script>

<style scoped>

</style>