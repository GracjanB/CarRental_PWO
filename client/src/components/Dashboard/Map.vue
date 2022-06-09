<template>
<div>

</div>
</template>

<script>
import $ from 'jquery';
import { LMap, LTileLayer, LMarker, LPopup} from "vue2-leaflet";
import { latLng } from "leaflet";
export default {
  name: "Map",
  components:{
    LMap,
    LTileLayer,
    LMarker,
    LPopup,
  },
  data() {
    return {
      loading: false,
      zoom: 13,
      center: latLng(50.0406546, 22.0028854),
      url: 'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
      attribution:
          '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors',

      map_scooter:[latLng(50.0406546, 22.0028854),latLng(50.0508546, 22.0061854),latLng(50.0300046, 22.0081324)],

      currentZoom: 11.5,
      currentCenter: latLng(50.0406546, 22.0028854),
      showParagraph: false,
      mapOptions: {
        zoomSnap: 0.5,
        scrollWheelZoom:false,
      },
      showMap: true
    };
  },
  methods: {

  },
  mounted() {

  }
}
</script>

<style scoped>

</style>