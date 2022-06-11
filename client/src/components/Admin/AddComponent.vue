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
export default {
  name: "AddComponent",
  methods:{

  },
  mounted() {

  }
}
</script>

<style scoped>

</style>