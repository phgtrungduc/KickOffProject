<template>
  <div>
      <Introduce/>
      <Content/>
  </div>
</template>

<script>
import Content from "./Content";
import Introduce from "./Introduce";
export default {
  name: "Homepage",
  components:{
      Content,
      Introduce
  }
};
</script>
<style>
</style>