<template>
<div>
  <HeaderComponent></HeaderComponent>
  <ScooterComponent></ScooterComponent>
  <AboutUsComponent></AboutUsComponent>
  <LocationsComponent></LocationsComponent>
  <PricerComponent></PricerComponent>
  <ContactComponent></ContactComponent>
  <FooterComponent></FooterComponent>
</div>
</template>

<script>
import HeaderComponent from "../components/HeaderComponent";
import ScooterComponent from "../components/Homepage/ScooterComponent";
import AboutUsComponent from "../components/Homepage/AboutUsComponent";
import LocationsComponent from "../components/Homepage/LocationsComponent";
import PricerComponent from "../components/Homepage/PricerComponent";
import ContactComponent from "../components/Homepage/ContactComponent";
import FooterComponent from "../components/FooterComponent";
import $ from "jquery";
export default {
  name: "HomepageComponent",
  components: {FooterComponent, ContactComponent, PricerComponent, LocationsComponent, AboutUsComponent, ScooterComponent, HeaderComponent},
  mounted() {
    $(".hp-menu").slideDown();
  }
}
</script>

<style scoped>

</style>