<template>
<div>
  <div class="w-100 h500 mt-5 mb-5 text-center position-relative">
    <div id="LOCATIONS">
      <l-map style="height: 600px" :zoom="zoom" :center="center" :options="mapOptions">
        <l-tile-layer :url="url" :attribution="attribution"></l-tile-layer>
        <l-marker :lat-lng="markerLatLng1"></l-marker>
        <l-marker :lat-lng="markerLatLng2"></l-marker>
        <l-marker :lat-lng="markerLatLng3"></l-marker>
      </l-map>
    </div>
  </div>
  <div class="container">
    <div class="card p-4 text-center mb-5">
      <h1 class="font-rider">Nasze punkty znajdziesz na ulicy:</h1>
      <div class="row pt-4">
        <div class="col-lg-4 col-md-12 location-square">
          <h1 class="font-rider blue">Rejtana</h1>
          <div class="location-box mt-4">
            <img :src="rejtana" class="location-img">
            <div class="font-rider location-street">
              ul. Rejtana 247
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-md-12 location-square">
          <h1 class="font-rider blue">Sucharskiego</h1>
          <div class="location-box mt-4">
            <img :src="sucharskiego" class="location-img">
            <div class="font-rider location-street">
              ul. Sucharskiego 54
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-md-12 location-square">
          <h1 class="font-rider blue">Piłsudskiego</h1>
          <div class="location-box mt-4">
            <img :src="resow" class="location-img">
            <div class="font-rider location-street">
              ul. Piłsudskiego 103
            </div>
          </div>
        </div>

      </div>
    </div>
  </div>
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
  name: "LocationsComponent",
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
    initMap:function (){
      $( document ).ready(function() {
        $(".leaflet-marker-icon").attr("src","logo_mini.png");
      });
    },
  },
  mounted() {
    this.initMap();
  },
}
</script>

<style scoped>

</style>