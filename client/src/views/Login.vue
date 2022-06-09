<template>
<div>

</div>
</template>

<script>
import $ from 'jquery'
import Header from "../components/Header";
import LoginBox from "../components/LoginBox/LoginBox";
import Footer from "../components/Footer";
export default {
  name: "Login",
  components: {Footer, LoginBox, Header},
  mounted() {
    $(".hp-menu").css("display","none");
  }
}
</script>

<style scoped>

</style>
