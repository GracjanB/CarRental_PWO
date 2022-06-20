<template>
<div>
  <div class="container text-center mt-5">
    <h1 class="font-rider pb-4" id="ABOUTUS">Dostępne</h1>
    <div class="card mt-4 mb-4 mobile-p1">

      <h1 class="font-rider blue pt-4">Dostępne:</h1>
     <div class="vehicle-list available mt-3 mb-2">
       <ul class="pl-0 available_ul">

       </ul>
     </div>

    </div>
  </div>
</div>
</template>

<script>
import $ from 'jquery';
export default {
  name: "AvailableComponent",
  methods:{
    goRent:function ()
    {
      $(".available .vehicle").click(function (){
        $(".available .vehicle").removeClass("active");
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
    showAvailable:function ()
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
        url: "https://car-rental-api-pwo.herokuapp.com/api/cars",
        success: function(data){
          var constr_available = "";
          console.log(data);
          var i = 1;
          data.forEach((entry) => {
            if(entry.isAvailable=="1")
              constr_available+= '<li class="pl-4 pr-4 pt-4 pb-4 vehicle '+((i==1)?' active ':'')+'" data-id="'+entry.id+'">\n' +
                  '           '+entry.mark+' '+entry.model+' (<small style="">'+entry.speed+' KM/H / '+entry.range+' KM</small>)\n' +
                  '         </li>';

            i++;
          });
          $(".available_ul").append(constr_available);
          console.log(constr_available);

          setTimeout(function(){ that.goRent(); }, 1000);
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
    var that = this;
    that.showAvailable();
  }
}
</script>

<style scoped>

</style>