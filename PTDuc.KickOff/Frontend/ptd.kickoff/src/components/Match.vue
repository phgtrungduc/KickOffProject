<template>
  <div class="match d-flex align-items-center">
    <div class="home-team d-flex align-items-center col-3">
      <div class="flag mr-2">
        <span class="flag-icon flag-icon-it"></span>
      </div>
      <div class="name">Thổ nhĩ kì</div>
    </div>
    <div class="score-box col-6">
      <div class="percent-line d-flex justify-content-around">
        <div>10%</div>
        <div>20%</div>
        <div>30%</div>
      </div>
      <div class="progress-line d-flex" style="height:10px;">
        <div
          class="bg-scale-100"
          style="width: 45%"
          data-original-title="Most likely result:<br>Torino wins (45 %)"
          data-toggle="tooltip"
        ></div>
        <div
          class="bg-gray-300"
          style="width: 29%"
        ></div>
        <div
          class="bg-gray-400"
          style="width: 26%"
        ></div>
      </div>
      <div class="time-line ">
        <div class="text-center">16:30 22 OCTOBER</div>
      </div>
    </div>
    <div class="visiting-team d-flex align-items-center col-3">
      <div class="flag mr-2">
        <span class="flag-icon flag-icon-us"></span>
      </div>
      <div class="name">Thổ nhĩ kì</div>
    </div>
  </div>
</template>
<script>

export default {
  name: "Match",
};

</script>
<style scoped>
.match {
  height: 100px;
  width: 500px;
  justify-content: space-evenly;
  font-size: 13px;
}
.score-box  *{
  margin-bottom: 3px;
}
@import url("../assets/styles/flags/css/flag-icon.css");
@import url("../assets/styles/backgroud.css");
</style>