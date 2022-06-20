<template>
  <div>
    <div class="container text-center mt-5">
      <h1 class="font-rider pb-4" id="ABOUTUS">Lokalizacja</h1>
      <div class="card mt-4  mb-4 mobile-p1">

        <h1 class="font-rider blue pt-4">Nasze samochody znajdziesz tu:</h1>



        <div class="mt-5" style="height: 500px; width: 100%">
          <l-map ref="mymap"
                 v-if="showMap"
                 :zoom="zoom"
                 :center="center"
                 :options="mapOptions"
                 :scroll-wheel-zoom="false"
                 style="height: 80%"
                 @update:center="centerUpdate"
                 @update:zoom="zoomUpdate"
          >
            <l-tile-layer
                :url="url"
                :attribution="attribution"
            />
            <div id="mapsmarker">
              <l-marker  :lat-lng="map_scooter[0]">
                <l-popup>
                  <div @click="innerClick">
                    Przykładowy pojazd 1
                  </div>
                </l-popup>
              </l-marker>


              <l-marker  :lat-lng="map_scooter[1]">
                <l-popup>
                  <div @click="innerClick">
                    Przykładowy pojazd 2
                  </div>
                </l-popup>
              </l-marker>


              <l-marker  :lat-lng="map_scooter[2]">
                <l-popup>
                  <div @click="innerClick">
                    Przykładowy pojazd 3
                  </div>
                </l-popup>
              </l-marker>
            </div>
          </l-map>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import $ from 'jquery';
import { LMap, LTileLayer, LMarker, LPopup} from "vue2-leaflet";
import { latLng } from "leaflet";
export default {
  name: "MapComponent",
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
    initMap:function (){
      $( document ).ready(function() {
        $(".leaflet-marker-icon").attr("src","logo_mini.png");
      });
    },
    initMarkers:function (){

    },
    getCookie:function (name)
    {
      var nameEQ = name + "=";
      var ca = document.cookie.split(';');
      for(var i=0;i < ca.length;i++) {
        var c = ca[i];
        while (c.charAt(0)==' ') c = c.substring(1,c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
      }
      return null;
    },
    zoomUpdate(zoom) {
      this.currentZoom = zoom;
    },
    centerUpdate(center) {
      this.currentCenter = center;
    },
    markerUpdate(marker){
      alert("ok");
      this.latLng = marker;
    },
    showLongText() {
      this.showParagraph = !this.showParagraph;
    },
    innerClick() {
      alert("Click!");
    }
  },
  mounted() {
  }
}
</script>

<style scoped>

</style>