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
export default {
  name: "RentComponent",
  data() {
  },
  methods: {
  },
  mounted() {

  }
}
</script>

<style scoped>

</style>