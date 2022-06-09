<template>
<div>

</div>
</template>

<script>
import $ from "jquery";
export default {
  name: "Rent",
  data() {
    return {
      isAdmin: ((this.getCookie("loginname") == "admin1")?1:null),
      qrCode: "https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=none",
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