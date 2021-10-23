<template>
  <v-app>
    <Header/>
    <v-main>
      <router-view></router-view>
    </v-main>
  </v-app>
</template>
<style>
#app {
  background: url("~@/assets/images/bg-stripes.svg") no-repeat right -1000px top 0;
}
body {
  margin: 0;
  font-family: "IBM Plex Sans", sans-serif;
  font-size: 1rem;
  font-weight: 400;
  line-height: 1.5;
  color: #314b49;
  text-align: left;
  padding: 0 80px 0 80px;
}

@import "~bootstrap/dist/css/bootstrap.css";
</style>
<script>
import Header from "./components/Header";
export default {
  name: "App",

  components: {
    Header,
  },

  data: () => ({
    //
  }),
};
</script>
