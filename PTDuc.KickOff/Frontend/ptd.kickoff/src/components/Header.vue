<template>
  <v-app-bar app rounded color="#FBFCFC" height="100px" id="app-bar">
    <!-- dark inverted-scroll -->
    <div class="d-flex align-center">
      <v-img
        alt="Vuetify Logo"
        class="shrink mr-2"
        contain
        src="@/assets/images/logo-kickoffai.svg"
        transition="scale-transition"
        width="150"
      />
    </div>
    <div class="header-router d-flex">
      
      <router-link to="/result"><div class="header-item">TRẬN ĐẤU</div></router-link>
      <div class="header-item">ĐỘI BÓNG</div>
      <div class="header-item">VỀ CHÚNG TÔI</div>
    </div>
    <v-spacer></v-spacer>
    <div class="search-box d-flex">
      <div class="serach-box-icon" for="search"></div>
      <div class="serach-box-text">
        <input type="text" id="search" placeholder="Tìm đội..." />
      </div>
    </div>
  </v-app-bar>
</template>
<style scoped>
#app-bar {
  padding: 0 64px 0 64px;
}
.search-box {
  padding: 13px;
  border-radius: 20px;
  font-size: 13px;
  width: 300px;
}

.header-item {
  font-size: 14px;
  font-weight: 400;
  margin: 0 10px 0 10px;
  
}
.header-router {
  margin-left: 50px;
  
}
.header-router a {
  text-decoration: none!important;
  color: black;
  
}
@media screen and (max-width: 600px) {
  .header-router {
    display: none;
  }
}
@import "../assets/styles/search-box.css";
</style>