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

export default {
  name: "LoginBoxComponent",
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