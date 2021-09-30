<template>
  <div>
    <b-container>
      <b-table striped over :items="students" :fields="fields" />
    </b-container>
    <nuxt-link to="/create">Create a New Student</nuxt-link>
  </div>
</template>
<script>
export default {
  data() {
    return {
      fields: ["username", "name", "email"],
      students: [],
    };
  },
  created() {
    this.$axios
      .$get("http://localhost:8080/academics/api/students/")
      .then((students) => {
        this.students = students;
      });
  },
};
</script>
<style></style>
