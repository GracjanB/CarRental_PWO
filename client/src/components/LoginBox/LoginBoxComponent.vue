<template>
  <div class="blue-bcg-hp" style="background: url('/Login/bcg.jpg')">
    <div class="container h-100 mxw-450">
        <div class="row h-100">
          <div class="col-lg-12 mt-4">
            <div class="card text-center p-5 mt-5">
              <img :src="logo" class="logo-hp m-auto pt-2 pb-3" alt="Rider">
            </div>
          </div>
          <div class="col-lg-12 mt-1">
            <div class="card text-center p-5 mt-4">
              <b-field class="font-rider " label="Email">
                <b-input name="login"
                         type="text"
                         size="small" id="login_field" required>
                </b-input>
              </b-field>
              <b-field class="font-rider " label="Hasło">
                <b-input name="password"
                         type="password"
                         size="small" id="password_field" required>
                </b-input>
              </b-field>
            </div>
          </div>
          <div style="margin-bottom: 210px;" class="col-lg-12 mt-1">
            <div class="card text-center p-5 mt-4 mb-5">
              <input id="Login" class="button blue-btn" type="submit" value="Zaloguj się"/>
            </div>
          </div>
        </div>
    </div>
  </div>
</template>

<script>
import $ from "jquery";
export default {
  name: "LoginBoxComponent",
  data: function () {
    return {
      logo: '/logo.png',
    }
  },
  methods:{
    ajaxlogin:function ()
    {
      var that= this;

      $( "#Login" ).click(function() {
        var login = $("#login_field").val(),password = $("#password_field").val();

        if(login!="" && password!= "")
        {
          $.ajax({
            contentType: "application/json",
            headers:{
              "accept":"text/plain",
              "Connection":"keep-alive"
            },
            type: "POST",
            url: "https://car-rental-api-pwo.herokuapp.com/api/auth/login",
            data: JSON.stringify({email:login,password:password}),
            success: function(data, textStatus, request){
              console.log("r"+request);
              console.log("t"+textStatus);
              that.$noty.success("Zostałeś pomyślnie zalogowany!");
              document.cookie = "loginid="+data.id;
              document.cookie = "loginname="+data.username;
              document.cookie = "logintoken="+data.token;
              location.reload();
            },
            error: function (request, textStatus, errorThrown) {
              console.log("ER"+errorThrown);
              that.$noty.error("Błędne dane logowania!");
            }

          });
        }
        else
        {
          that.$noty.error("Błędnie wypełnione pola logowania!");
        }
      });

    },
  },

  mounted() {
    this.ajaxlogin();
  }
}
</script>

<style scoped>

</style>