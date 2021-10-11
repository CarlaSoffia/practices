<template>
  <b-container>
    <h4>Administrator Details:</h4>
    <p>Username: {{ administrator.username }}</p>
    <p>Name: {{ administrator.name }}</p>
    <p>Email: {{ administrator.email }}</p>
    <p>Password: {{ administrator.password }}</p>

     <nuxt-link to="/administrators"><img
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
      administrator: {}
    };
  },
  computed: {
    username() {
      return this.$route.params.username;
    },
  },
  created() {
    this.$axios
      .$get(`/api/administrators/${this.username}`)
      .then((administrator) => (this.administrator = administrator || {}))
  },
};
</script>
