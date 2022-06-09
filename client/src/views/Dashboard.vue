<template>
<div>

</div>
</template>

<script>
import Footer from "../components/Footer";
import Header from "../components/Header";
import Available from "../components/Dashboard/Available";
import Rent from "../components/Dashboard/Rent";
import Map from "../components/Dashboard/Map";
import Payment from "../components/Dashboard/Payment";
import FinishPay from "../components/Dashboard/FinishPay";
import Add from "../components/Admin/Add";
export default {
  name: "Dashboard",
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
  components: {Add, FinishPay, Payment, Map, Rent, Available, Header, Footer}
}
</script>

<style scoped>

</style>