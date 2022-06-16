<template>
<div>
  <div class="container text-center mt-5">
    <h1 class="font-rider pb-4" id="PRICER">Cennik</h1>
    <h3 class="font-rider blue">U nas nie przepłacasz!</h3>

    <div class="row mt-5">
      <div class="col-lg-4 col-md-12">
        <div class="card pricer-box mb-4" style="background-size: cover;">
          <kinesis-container class="container">
          <kinesis-element :strength="10">
          <h1 class="font-rider" style="margin-top: 80px;">OPCJA 1</h1>
          </kinesis-element>
          </kinesis-container>
          <h2 class="font-rider blue">
            Tydzień: 500 zł
          </h2>
        </div>
      </div>

      <div class="col-lg-4 col-md-12">
        <div class="card pricer-box mb-4" style="background-size: contain;">
          <kinesis-container class="container">
            <kinesis-element :strength="10">
              <h1 class="font-rider" style="margin-top: 80px;">OPCJA 2</h1>
            </kinesis-element>
          </kinesis-container>
          <h2 class="font-rider blue">
            2 dni: 180 zł
          </h2>
        </div>
      </div>

      <div class="col-lg-4 col-md-12">
        <div class="card pricer-box mb-4" style="background-size: contain;">
          <kinesis-container class="container">
            <kinesis-element :strength="10">
              <h1 class="font-rider" style="margin-top: 80px;">OPCJA 3</h1>
            </kinesis-element>
          </kinesis-container>
          <h2 class="font-rider blue">
            1 dzień: 100 zł
          </h2>
        </div>
      </div>


    </div>

  </div>
</div>
</template>

<script>
export default {
  name: "PricerComponent"
}
</script>

<style scoped>

</style>