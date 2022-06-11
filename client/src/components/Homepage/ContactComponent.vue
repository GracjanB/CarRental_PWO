<template>
  <div>
    <div class="container text-center mt-5">
      <h1 class="font-rider pb-4 blue" id="CONTACT">Kontakt</h1>
      <div class="card contact-card mb-5" style="background: url('/Homepage/contact.jpg');background-size: cover;">
        <div class="row m-0">
            <div class="col-lg-4 col-md-12">
              <div class="contact-b1">
                <div class="row">
                  <div class="col-lg-6 col-md-6">
                    <a>
                      <img :src="fb" class="fb mt-3" alt="Facebook">
                    </a>
                  </div>
                  <div class="col-lg-6 col-md-6">
                    <a>
                      <img :src="insta" class="insta" alt="Insta">
                    </a>
                  </div>
                  <div class="col-lg-12"><div><h2 class="mt-5"><a class="font-rider color-inherit mail-hover" href="email:projektbolt@bolt.pl">projektbolt@bolt.pl</a></h2></div></div>
                  <div class="col-lg-12"><div><h2 class="mt-5"><a class="font-rider color-inherit mail-hover" href="tel:72988454">729 988 454</a></h2></div></div>

                </div>
              </div>
            </div>
            <div class="col-lg-8 col-md-12">
              <div class="contact-b1">
                <h1 class="font-rider pb-4 blue"><br>Zapraszamy do kontaktu w dniach:<br><br>PN - PT<br>8:00 - 20:00<br><br>SO<br>8:00 - 15:00</h1>
              </div>
            </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "ContactComponent",
  data: function ()
  {
    return {
      fb: '/Homepage/fcb.svg',
      insta: '/Homepage/insta.svg',
    }
  }
}
</script>

<style scoped>

</style>