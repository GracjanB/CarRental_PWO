<template>
<div>
  <Header></Header>
  <RegisterBox></RegisterBox>
  <Footer></Footer>
</div>
</template>

<script>
import $ from 'jquery'
import Header from "../components/Header";
import Footer from "../components/Footer";
import RegisterBox from "../components/RegisterBox/RegisterBox";
export default {
  name: "Register",
  components: {Footer, RegisterBox, Header},
  mounted() {
    $(".hp-menu").css("display","none");
  }
}
</script>

<style scoped>

</style>
