<template>
<div class="blue-bcg-hp">
 <div class="container h-100 nonbgs">
   <div class="row h-100">
     <div class="col-lg-12 pt-5 pb-5 h-100">
       <kinesis-container class="container">

       <div class="card shadow-lg h-100">
         <div class="row h-100 m-0" style="background: url('/Homepage/people2.png')">
           <div class="col-lg-7 h-100 d-flex justify-content-center align-items-center">
             <kinesis-element :strength="40">
             <div class="card text-center p-5 mt200">
               <h1 class="font-rider blue">Witaj!</h1>
               <img :src="logo" class="logo-hp m-auto pt-2 pb-3" alt="Rider">
               <h2 class="font-rider">Poprowadzi Cię!</h2>
             </div>
             </kinesis-element>

           </div>
           <div class="col-lg-5 d-flex justify-content-center align-items-center">
             <kinesis-element :strength="40">
              <img :src="scooter" class="move carmove">
             </kinesis-element>
           </div>
         </div>
       </div>

       </kinesis-container>


     </div>
   </div>
 </div>
</div>
</template>

<script>
import $ from 'jquery'
export default {
  name: "ScooterComponent",
  data: function (){
    return{
      logo: '/logo.png',
      scooter: '/Homepage/scooter2.png',
    }
  },
  methods:{
    moveImage:function ()
    {
      $(window).mousemove(function(event) {
        $(".move").css({"left" : event.pageX, "top" : event.pageY});
      });
    },
  },
  mounted() {
    this.moveImage()
  }
}
</script>

<style scoped>
</style>