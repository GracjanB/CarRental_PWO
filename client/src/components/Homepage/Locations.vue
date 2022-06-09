<template>
<div>

</div>
</template>

<script>
import {LMap,LTileLayer,LMarker} from "vue2-leaflet";
import $ from "jquery";

export default {
  components:{
   LMap,
    LTileLayer,
    LMarker,
  },
  name: "Locations",
  data: function ()
  {
    return{
      rejtana: '/Homepage/rejtana.jpg',
      sucharskiego: '/Homepage/sucharskiego.jpg',
      resow: '/Homepage/resow.jpg',
      url: 'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
      attribution:
          '&copy; <a target="_blank" href="http://osm.org/copyright">OpenStreetMap</a> contributors',
      zoom: 13,
      center: [50.0376508, 22.0135127],
      markerLatLng1: [50.0187928, 22.0135127],
      markerLatLng2: [50.0476508, 21.9791406],
      markerLatLng3: [50.0404631, 22.0014316],
      mapOptions: {
        scrollWheelZoom:false,

      },
    }
  },
  methods: {

  },
  mounted() {

  },
}
</script>

<style scoped>

</style>