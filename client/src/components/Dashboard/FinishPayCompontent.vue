<template>
<div>
  <div class="container text-center mt-5">
    <h1 class="font-rider pb-4" id="FINISHPAY">Sfinalizuj transakcję</h1>
    <div class="card mt-4  mb-4 mobile-p1">
      <div class="row FINISH_RENT">
        <div class="col-lg-4 col-md-12">
          <span class="r_n">---</span>
        </div>
        <div class="col-lg-4 col-md-12">
          <span class="s_r start_rent">---</span>
        </div>
        <div class="col-lg-4 col-md-12">
          <span class="e_r end_rent">---</span>
        </div>
        <div class="col-lg-12 col-md-12">
            <input type="text" class="d-none" id="rent_start" value="0">
            <input type="text" class="d-none" id="rent_end" value="0">
            <input type="text" class="d-none" id="rent_user" value="0">
            <input type="text" class="d-none" id="rent_ontime" value="1">
            <input type="text" class="d-none" id="rent_vehicle" value="1">
          <span id="pay" class="finish_pay mt-4">PŁACĘ</span>
        </div>
      </div>
    </div>
  </div>
</div>
</template>

<script>
export default {
  name: "FinishPayComponent"
}
</script>

<style scoped>

</style>