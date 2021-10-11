<template>
  <b-container>
    <h4>Teacher Details:</h4>
    <p>Username: {{ teacher.username }}</p>
    <p>Name: {{ teacher.name }}</p>
    <p>Email: {{ teacher.email }}</p>
    <p>Password: {{ teacher.password }}</p>
    <p>Office: {{ teacher.office }}</p>

     <nuxt-link to="/teachers"><img
              src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
              alt="update"
              width="25"
              height="25"
      /></nuxt-link>
  </b-container>
</template>
<script>
export default {
  data() {
    return {
      teacher: {}
    };
  },
  computed: {
    username() {
      return this.$route.params.username;
    },
  },
  created() {
    this.$axios
      .$get(`/api/teachers/${this.username}`)
      .then((teacher) => (this.teacher = teacher || {}))
  },
};
</script>
