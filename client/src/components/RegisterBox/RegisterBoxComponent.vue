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
export default {
  name: "RegisterBoxComponent",
  data: function () {
    return {
      logo: '/logo.png',
    }
  },
  methods:{

  },
  mounted() {
  }
}
</script>

<style scoped>

</style>