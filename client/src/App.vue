<template>
  <div id="app">
    <div id="nav">
    </div>
    <router-view/>
  </div>
</template>
<style>
@import './assets/libs/leaflet/leaflet.css';
@import './assets/style.css';
@font-face {
  font-family: "Paca";
  src: local("Pacifico-Regular"),
  url("../public/Fonts/Pacifico-Regular.ttf") format("truetype"),
  url("../public/Fonts/Pacifico-Regular.woff") format("woff"),
  url("../public/Fonts/Pacifico-Regular.woff2") format("woff2"),
  url("../public/Fonts/Pacifico-Regular.eot") format("embedded-opentype"),
  url("../public/Fonts/Pacifico-Regular.svg") format("svg");
}
@font-face {
  font-family: "Quad";
  src: local("Quadrangle-Regular"),
  url("../public/Fonts/Quadrangle-Regular.ttf") format("truetype"),
  url("../public/Fonts/Quadrangle-Regular.woff") format("woff"),
  url("../public/Fonts/quadrangle.woff2") format("woff2"),
  url("../public/Fonts/quadrangle.eot") format("embedded-opentype"),
  url("../public/Fonts/Quadrangle-Regular.svg") format("svg");
}
@font-face {
  font-family: "Ubuntu-Regular";
  src: local("Ubuntu-Regular"),
  url("../public/Fonts/Ubuntu-Regular.ttf") format("truetype");
}
@font-face {
  font-family: "Ubuntu-Light";
  src: local("Ubuntu-Light"),
  url("../public/Fonts/Ubuntu-Light.ttf") format("truetype");
}
</style>



