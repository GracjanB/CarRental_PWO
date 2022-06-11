<template>
<div>
  <div class="container text-center mt-5">
    <h1 class="font-rider pb-4" id="ABOUTUS">O nas</h1>
    <div class="card mt-4 p-5">
    <span class="ur">
      Zajmujemy się wypożyczaniem małych samochodów elektrycznych do jazdy po Rzeszowie. Nasze samochody mają za zadanie doprowadzić Państwa szybko i bezpiecznie do celu. Jesteśmy profesjonalistami w swoim fachu, ponieważ gwarantujemy Państwu najwyższej klasy pojazdy z najwyższych dostępnych roczników w bardzo dobrym stanie technicznym. Wybierając nas, otrzymujecie Państwo gwarancję bezpieczeństwa oraz zadowolenia. Działamy na rynku od 4 lat, a tyśiące naszych klientów może poświadczyć o naszym profesjonalnym podejściu.
    </span>
      <h1 class="font-rider blue pt-4">Zapraszamy do skorzystania z naszych usług!</h1>

      <div class="pt-4">
        <kinesis-container class="container">
        <kinesis-element :strength="40">
        <img :src="egolf" alt="Scooter [from www.behance.net/gallery/97201095/Scoot]" class="mxw-300">
        </kinesis-element>
        </kinesis-container>
      </div>

    </div>
  </div>
</div>
</template>

<script>
export default {
  name: "AboutUsComponent",
  data: function ()
  {
    return{
      egolf: '/Homepage/egolf.png',
    }
  }
}
</script>

<style scoped>

</style>