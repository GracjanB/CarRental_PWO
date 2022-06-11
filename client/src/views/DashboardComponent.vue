<template>
<div>
  <HeaderComponent></HeaderComponent>
  <div class="row">
    <div class="col-lg-4 col-md-12">
      <AvailableComponent></AvailableComponent>
    </div>
    <div class="col-lg-4 col-md-12">
      <PaymentComponent v-if="isUser"></PaymentComponent>
    </div>
    <div class="col-lg-4 col-md-12">
      <RentComponent></RentComponent>
    </div>
    <div class="col-lg-12 col-md-12">
      <MapComponent v-if="isUser"></MapComponent>
    </div>
    <div class="col-lg-12 col-md-12">
      <FinishPayComponent v-if="isUser"></FinishPayComponent>
    </div>
  </div>
  <FooterComponent></FooterComponent>
</div>
</template>

<script>
import FooterComponent from "../components/FooterComponent";
import HeaderComponent from "../components/HeaderComponent";
import AvailableComponent from "../components/Dashboard/AvailableComponent";
import RentComponent from "../components/Dashboard/RentComponent";
import MapComponent from "../components/Dashboard/MapComponent";
import PaymentComponent from "../components/Dashboard/PaymentComponent";
import FinishPayComponent from "../components/Dashboard/FinishPayCompontent";
export default {
  name: "DashboardComponent",
  data() {
    return {
      isAdmin: ((this.getCookie("loginname") == "admin1")?1:null),
      isUser: ((this.getCookie("loginname") == "admin1")?null:1),
    };
  },
  methods:{
    getCookie:function (name)
    {
      var nameEQ = name + "=";
      var ca = document.cookie.split(';');
      for(var i=0;i < ca.length;i++) {
        var c = ca[i];
        while (c.charAt(0)==' ') c = c.substring(1,c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
      }
      return null;
    },
  },
  mounted() {

  },
  components: { FinishPayComponent, PaymentComponent, MapComponent, RentComponent, AvailableComponent, HeaderComponent, FooterComponent}
}
</script>

<style scoped>

</style>