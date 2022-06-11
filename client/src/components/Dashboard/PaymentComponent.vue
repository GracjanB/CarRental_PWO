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

export default {
  name: "PaymentComponent",
  methods: {
  },
  mounted() {
  }
}
</script>

<style scoped>

</style>