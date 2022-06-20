<template>
<div>
  <div class="container text-center mt-5">
    <h1 class="font-rider pb-4" id="ABOUTUS">Wypożyczone</h1>
    <div class="card mt-4  mb-4 mobile-p1">

      <h1 class="font-rider blue pt-4">Wypożyczone:</h1>
      <div class="vehicle-list mt-3 mb-2">
        <ul class="pl-0 rent_ul">

        </ul>
      </div>
      <div class="mt-4 mb-4">
        Przyłóż kod QR do czytnika pojazdu (czytnik znajduje się przy stacji dostępu obok pojazdu) i otrzymaj dostęp!<br><br>
        <img width="150px;" :src="qrCode">
      </div>
    </div>
  </div>
</div>
</template>

<script>
import $ from "jquery";
export default {
  name: "RentComponent",
  data() {
    return {
      isAdmin: ((this.getCookie("loginname") == "admin1")?1:null),
      qrCode: "https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=none",
    };
  },
  methods: {
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
    takeRentsAll:function ()
    {
      var that = this;
      $.ajax({
        contentType: "application/json",
        headers:{
          "accept":"text/plain",
          "Connection":"keep-alive",
          "Authorization":"Bearer "+that.getCookie("logintoken"),
        },
        type: "GET",
        url: "https://car-rental-api-pwo.herokuapp.com/api/rentals/",
        success: function(data){
          var constr_rent = "";
          console.log(data);
          var i = 1;
          data.forEach((entry) => {
            var diffInMilliseconds = Math.abs(new Date(entry.startRental) - new Date(entry.endRental));
            var hours_diff = Math.floor(diffInMilliseconds / 3600) % 24;
            var class_rent_img = '';
            if(hours_diff==24)
              class_rent_img = "picto_1";
            else if(hours_diff==48)
              class_rent_img = "picto_12";
            else
              class_rent_img = "picto_24";

            if (new Date(entry.endRental)>new Date())
            {
              constr_rent+= '<li class="pl-4 pr-4 pt-4 pb-4 ">\n' +
                  '            '+entry.car.mark+' '+entry.car.model+'\n' +
                  '            <div class="rent_">\n' +
                  '              <div class="row">\n' +
                  '                <div class="col-lg-4 col-md-12">\n' +
                  '                  <span class="start_rent">'+entry.startRental.replace("T0"," ").replace("T1"," ")+'</span>\n' +
                  '                </div>\n' +
                  '                <div class="col-lg-4 col-md-12">\n' +
                  '                  <span class="end_rent">'+entry.endRental.replace("T0"," ").replace("T1"," ")+'</span>\n' +
                  '                </div>\n' +
                  '                <div class="col-lg-4 col-md-12">\n' +
                  '                  <span class="rent_picto '+class_rent_img+'"></span>\n' +
                  '                </div>\n' +
                  '              </div>\n' +
                  '            </div>\n' +
                  '          </li>';
            }
            i++;
            console.log(i);
          });
          $(".rent_ul").append(constr_rent);

        },
        error: function (request, textStatus, errorThrown) {
          console.log(request);
          console.log("ER"+textStatus);
          console.log("ER"+errorThrown);
        }

      });
    },
    takeRents:function () {
      var that = this;
      $.ajax({
        contentType: "application/json",
        headers:{
          "accept":"text/plain",
          "Connection":"keep-alive",
          "Authorization":"Bearer "+that.getCookie("logintoken"),
        },
        type: "GET",
        url: "https://car-rental-api-pwo.herokuapp.com/api/rentals/filter/user/"+that.getCookie("loginid"),
        success: function(data){
          var constr_rent = "";
          console.log(data);
          var i = 1;
          data.forEach((entry) => {
            var diffInMilliseconds = Math.abs(new Date(entry.startRental) - new Date(entry.endRental));
            var hours_diff = Math.floor(diffInMilliseconds / 3600) % 24;
            var class_rent_img = '';
            if(hours_diff==1)
              class_rent_img = "picto_1";
            else if(hours_diff==12)
              class_rent_img = "picto_12";
            else
              class_rent_img = "picto_24";
            console.log("MOJEENTRY");
            console.log(entry);
            if (new Date(entry.endRental)>new Date())
              constr_rent+= '<li class="pl-4 pr-4 pt-4 changeQR" data-vehicleid="'+entry.car.id+'">\n' +
                  '            '+entry.car.mark+' '+entry.car.model+'\n' +
                  '            <div class="rent_">\n' +
                  '              <div class="row">\n' +
                  '                <div class="col-lg-4 col-md-12">\n' +
                  '                  <span class="start_rent">'+entry.startRental.replace("T0"," ").replace("T1"," ")+'</span>\n' +
                  '                </div>\n' +
                  '                <div class="col-lg-4 col-md-12">\n' +
                  '                  <span class="end_rent">'+entry.endRental.replace("T0"," ").replace("T1"," ")+'</span>\n' +
                  '                </div>\n' +
                  '                <div class="col-lg-4 col-md-12">\n' +
                  '                  <span style="position: relative;top: -40px;" class="rent_picto '+class_rent_img+'"></span>\n' +
                  '                </div>\n' +
                  '              </div>\n' +
                  '            </div>\n' +
                  '          </li>';
            setTimeout(function(){
              $( ".changeQR" ).unbind().click(function() {
                var vehicleid = $(this).data("vehicleid");
                that.qrCode = "https://api.qrserver.com/v1/create-qr-code/?size=150x150&data="+vehicleid;
              });
            }, 300);
            if (new Date(entry.endRental)<new Date())
            {
              console.log(entry);
              console.log("")
              // alert(entry.vehicle.id);
              console.log("ROZPOCZYNAM PROCEDURE ZWROTU");
              //  procedura automatycznego zwrotu
              $.ajax({
                contentType: "application/json",
                headers:{
                  "accept":"text/plain",
                  "Connection":"keep-alive",
                  "Authorization":"Bearer "+that.getCookie("logintoken"),
                },
                type: "PUT",
                url: "https://car-rental-api-pwo.herokuapp.com/api/rentals",
                data: JSON.stringify({id:entry.id, startRental:entry.startRental,endRental:entry.endRental,totalPrice:0,car:entry.car}),
                success: function(data, textStatus, request){
                  console.log(data);
                  console.log(textStatus);
                  console.log(request);
                  $.ajax({
                    contentType: "application/json",
                    headers:{
                      "accept":"text/plain",
                      "Connection":"keep-alive",
                      "Authorization":"Bearer "+that.getCookie("logintoken"),
                    },
                    type: "PUT",
                    url: "https://car-rental-api-pwo.herokuapp.com/api/cars",
                    data: JSON.stringify({id:entry.car.id,mark:null,model:null,range:null,speed:null,pricePerHour:null,vehicleType:null,isAvailable:true}),
                    success: function(){
                      location.reload();
                    },
                  });
                },
              });
            }
            i++;
            console.log(i);
          });
          $(".rent_ul").append(constr_rent);
        },
        error: function (request, textStatus, errorThrown) {
          console.log(request);
          console.log("ER"+textStatus);
          console.log("ER"+errorThrown);
        }
      });
    }
  },
  mounted() {

  }
}
</script>

<style scoped>

</style>