<template>
<div>
  <Header></Header>
  <Scooter></Scooter>
  <AboutUs></AboutUs>
  <Locations></Locations>
  <Pricer></Pricer>
  <Contact></Contact>
  <Footer></Footer>
</div>
</template>

<script>
import Header from "../components/Header";
import Scooter from "../components/Homepage/Scooter";
import AboutUs from "../components/Homepage/AboutUs";
import Locations from "../components/Homepage/Locations";
import Pricer from "../components/Homepage/Pricer";
import Contact from "../components/Homepage/Contact";
import Footer from "../components/Footer";
import $ from "jquery";
export default {
  name: "Homepage",
  components: {Footer, Contact, Pricer, Locations, AboutUs, Scooter, Header},
  mounted() {
    $(".hp-menu").slideDown();
  }
}
</script>

<style scoped>

</style>
