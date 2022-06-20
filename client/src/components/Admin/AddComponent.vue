<template>
  <div>
    <div class="container text-center mt-5">
      <h1 class="font-rider pb-4" id="ABOUTUS">Dodaj</h1>
      <div class="card mt-4 mb-4 mobile-p1">

        <h1 class="font-rider blue pt-4 mb-4">Wpisz dane</h1>

        <b-field class="font-rider " label="Marka">
          <b-input name="brand_"
                   type="text"
                   size="small" id="brand_" required>
          </b-input>
        </b-field>

        <b-field class="font-rider " label="Model">
          <b-input name="model_"
                   type="text"
                   size="small" id="model_" required>
          </b-input>
        </b-field>

        <b-field class="font-rider " label="Prędkość">
          <b-input name="speed_"
                   type="text"
                   size="small" id="speed_" required>
          </b-input>
        </b-field>

        <b-field class="font-rider " label="Zasięg">
          <b-input name="range_"
                   type="text"
                   size="small" id="range_" required>
          </b-input>
        </b-field>

        <input id="AddNewScooter" class="button blue-btn mt-3" type="submit" value="Dodaj"/>



      </div>
    </div>
  </div>
</template>

<script>
import $ from "jquery";
export default {
  name: "AddComponent",
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
    addNewScooter:function ()
    {
      var that = this;
      $( "#AddNewScooter" ).unbind().click(function() {
        var brand = $("#brand_").val(),model = $("#model_").val(),speed = $("#speed_").val(),range = $("#range_").val();

        if(brand!="" && model != "" && speed != "" && range !="")
        {
          $.ajax({
            contentType: "application/json",
            headers:{
              "accept":"text/plain",
              "Connection":"keep-alive",
              "Authorization":"Bearer "+that.getCookie("logintoken"),
            },
            type: "POST",
            url: "https://car-rental-api-pwo.herokuapp.com/api/cars",
            data: JSON.stringify({mark:brand,model:model,range:parseInt(range),speed:parseInt(speed),pricePerHour:1,vehicleType:0,isAvailable:true}),
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
          that.$noty.error("Błędnie wypełnione pola!");
      });
    }
  },
  mounted() {
    this.addNewScooter();
  }
}
</script>

<style scoped>

</style>