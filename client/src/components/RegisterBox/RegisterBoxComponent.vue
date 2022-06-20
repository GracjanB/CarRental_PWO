<template>
  <div class="blue-bcg-hp" style="background: url('/Register/bcg.jpg')">
    <div class="container h-100 mxw-450">
        <div class="row h-100">
          <div class="col-lg-12 mt-4">
            <div class="card text-center p-5 mt-5">
              <img :src="logo" class="logo-hp m-auto pt-2 pb-3" alt="Rider">
              <h1 class="font-rider blue">Dołącz do nas!</h1>
            </div>
          </div>

          <div class="col-lg-12 mt-1">
            <div class="card text-center p-5 mt-4 login_ok">
                <b-field class="font-rider " label="Nazwa">
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
                <b-field class="font-rider " label="Email">
                  <b-input type="email"
                           name="mail"
                           size="small"
                           maxlength="50" id="email_field" required>
                  </b-input>
                </b-field>
            </div>
          </div>

          <div class="col-lg-12 mt-1">
            <div class="card text-center p-5 mt-4 mb-5">
              <input class="button blue-btn" id="Register" type="submit" value="Rejestracja"/>
            </div>
          </div>

        </div>
    </div>
  </div>
</template>

<script>
import $ from 'jquery'
export default {
  name: "RegisterBoxComponent",
  data: function () {
    return {
      logo: '/logo.png',
    }
  },
  methods:{
    registerajax:function ()
    {
      var that= this;

      $( "#Register" ).unbind().click(function() {
        var login = $("#login_field").val(),password = $("#password_field").val(),email =$("#email_field").val();

        if(login!="" && password!= "" && email!="")
        {
          if(email.includes("@") && email.includes("."))
          {
            if(password.length>=4 && password.length<=16 && (password != password.toLowerCase()))
            {
              $.ajax({
                contentType: "application/json",
                headers:{
                  "accept":"text/plain",
                  "Connection":"keep-alive"
                },
                type: "POST",
                url: "https://car-rental-api-pwo.herokuapp.com/api/auth/register",
                data: JSON.stringify({email:email,username:login,password:password}),
                success: function(data, textStatus, request){
                  console.log("r"+request);
                  console.log("t"+textStatus);
                  that.$noty.success("Zostałeś pomyślnie zarejestrowany, teraz możesz się zalogować!");
                  $(".login_ok").html("<h4>Rejestracja pomyślna<br>Teraz możesz się zalogować</h4>")
                },
                error: function (request, textStatus, errorThrown) {
                  console.log("ER"+errorThrown);
                  that.$noty.error("UPS! Wygląda na to iż taki użytkownik istnieje");
                }
              });
            }
            else
            {
              that.$noty.error("Błędne hasło, wymagane: 4-16 znaków z min. 1 cyfrą i min. 1 dużą literą");
            }
          }
          else
          {
            that.$noty.error("Błędny adres e-mail");
          }
        }
        else
        {
          that.$noty.error("Błędnie wypełnione pola rejestracji!");
        }
      });
    },
  },
  mounted() {
    this.registerajax();
  }
}
</script>

<style scoped>

</style>