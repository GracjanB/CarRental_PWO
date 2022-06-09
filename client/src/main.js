import Vue from 'vue'
import App from './App.vue'
import router from './router'
import Buefy from 'buefy'
import { library } from '@fortawesome/fontawesome-svg-core'
import { faUserSecret } from '@fortawesome/free-solid-svg-icons'
import { faArrowCircleUp } from '@fortawesome/free-solid-svg-icons'
import {FontAwesomeIcon} from "@fortawesome/vue-fontawesome"
import 'buefy/dist/buefy.css'
import 'buefy/dist/components/icon/index'
import 'bootstrap/dist/css/bootstrap.css'
import $ from 'jquery'
var VueScrollTo = require('vue-scrollto');
import VueNoty from 'vuejs-noty';
import 'vuejs-noty/dist/vuejs-noty.css';
import { LMap, LTileLayer, LMarker, LPopup, LTooltip } from "vue2-leaflet";
import 'leaflet/dist/leaflet.css';
import * as VueAos from 'vue-aos'

library.add(faUserSecret)
library.add(faArrowCircleUp)
Vue.component('font-awesome-icon',FontAwesomeIcon)
Vue.use(Buefy)
Vue.use($)
Vue.use(require('vue-moment'));
Vue.use(VueScrollTo)
Vue.use(VueNoty,{
  timeout: 2300,
  progressBar: true
});
Vue.use(VueAos);
Vue.component('l-map', LMap);
Vue.component('l-tile-layer', LTileLayer);
Vue.component('l-marker', LMarker);
Vue.component('l-popup', LPopup);
Vue.component('l-tooltip', LTooltip);

new Vue({
  router,
  render: h => h(App)
}).$mount('#app')
