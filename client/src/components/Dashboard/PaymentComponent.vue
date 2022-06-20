<template>
<div>
  <div class="container text-center mt-5">
    <h1 class="font-rider pb-4" id="ABOUTUS">Zapłać</h1>
    <div class="card mt-4 mb-4 mobile-p1">

      <h1 class="font-rider blue pt-4">Płatność</h1>

      <div class="card pricer-box mb-4 mt-4  active" data-id="168"><h2 class="font-rider blue"> Tydzień: 500 zł </h2></div>
      <div class="card pricer-box mb-4 mt-4 " data-id="48"><h2 class="font-rider blue"> 2 dni: 180 zł </h2></div>
      <div class="card pricer-box mb-4 mt-4 " data-id="24"><h2  class="font-rider blue"> 1 dzień: 100 zł </h2></div>

      <div class="przelewy24">
        <span id="countpay" v-scroll-to="'#FINISHPAY'"> Przelicz </span>
      </div>

    </div>
  </div>
</div>
</template>

<script>
import $ from "jquery";
export default {
  name: "PaymentComponent",
  methods: {
    pad:function (n){
      return n<10 ? '0'+n : n;
    },
    getDateNow:function (dateIn){
      var yyyy = dateIn.getFullYear();
      var mm = dateIn.getMonth() + 1; // getMonth() is zero-based
      var dd = dateIn.getDate();
      var h = this.pad(dateIn.getHours())+":"+ this.pad(dateIn.getMinutes());
      return String(yyyy +"-"+this.pad(mm)+"-" + this.pad(dd)+" "+h); // Leading zeros for mm and dd
    },
    selectPaymentOption:function (){
      $( ".pricer-box.mini" ).click(function() {
        $(".pricer-box.mini").removeClass("active");
        $(this).addClass("active");
      });
    },
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
    finishPayment:function (){
      var that = this;
      $( "#countpay" ).unbind().click(function() {
        var vehicle_name = $(".vehicle.active").text();
        var vehicle_id = $(".vehicle.active").data("id");
        var hours_to_add = $(".pricer-box.active").data("id");

        $(".r_n").text(vehicle_name);
        $(".rent_vehilce").val(vehicle_id);

        var now = new Date();
        var after = new Date();
        now = that.getDateNow(now);
        $(".s_r").html(now);

        $("#rent_start").attr("value",now);

        after.setHours(after.getHours()+hours_to_add);
        after = that.getDateNow(after);

        $(".e_r").html(after)
        $("#rent_end").attr("value",after);

        $("#rent_user").attr("value",that.getCookie("loginid"));
        $("#rent_ontime").attr("value",hours_to_add);
        $("#rent_vehicle").attr("value",vehicle_id);
      });
      //zapłać
      $( "#pay" ).unbind().click(function() {
        var startRent = $("#rent_start").val();
        var endRent = $("#rent_end").val();
        var vehicleId = $("#rent_vehicle").val();
        var userId = $("#rent_user").val();
        var typeTime = $("#rent_ontime").val();

        startRent = new Date(startRent);
        endRent = new Date(endRent);

        console.log(startRent);
        console.log(endRent);

        //Request wypozyczenia
        $.ajax({
          contentType: "application/json",
          headers:{
            "accept":"text/plain",
            "Connection":"keep-alive",
            "Authorization":"Bearer "+that.getCookie("logintoken"),
          },
          type: "POST",
          url: "https://car-rental-api-pwo.herokuapp.comapi/rentals",
          data: JSON.stringify({startRental:startRent,endRental:endRent,totalPrice:parseInt(typeTime),discount:0,carId:vehicleId,userId:userId}),
          success: function(data, textStatus, request){
            console.log("r"+request);
            if(textStatus == "success")
            {
              $("#pay").slideUp();
              that.$noty.success("Pomyślne wypożyczenie pojazdu! Za chwilę zostaniesz przekierowany...");
              $.ajax({
                contentType: "application/json",
                headers:{
                  "accept":"text/plain",
                  "Connection":"keep-alive",
                  "Authorization":"Bearer "+that.getCookie("logintoken"),
                },
                type: "PUT",
                url: "https://car-rental-api-pwo.herokuapp.com/api/cars",
                data: JSON.stringify({id:vehicleId,mark:null,model:null,range:null,speed:null,pricePerHour:null,vehicleType:null,isAvailable:false}),
                success: function(data){
                  console.log("SUCCESS RESET!");
                  console.log(data);
                  location.reload();
                },
                error: function (request, textStatus, errorThrown) {
                  console.log(request);
                  console.log("ER"+textStatus);
                  console.log("ER"+errorThrown);
                }
              });
            }
            else
            {
              that.$noty.error("Wystąpił błąd! Spróbuj ponownie!");
            }
            console.log(data);
          },
          error: function (request) {
            console.log(request);
          }

        });

      });
    },
  },
  mounted() {
    this.selectPaymentOption();
    this.finishPayment();
  }
}
</script>

<style scoped>

</style>