<template>
  <div>
    <b-container
      class="form-group w-50"
      style="margin-left: 75px"
      @submit.prevent="create"
    >
      <h4>Create new Course</h4>
      <div>Code: <input v-model="code" type="number" min="1"  class="form-control"/></div>
      <div>Name: <input v-model="name" type="text"  class="form-control"/></div>
<br>
      <nuxt-link to="/courses"
        ><img
          src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
          alt="update"
          width="25"
          height="25"
      /></nuxt-link>
      <button class="btn btn-info" type="reset">Reset</button>
      <button class="btn btn-info" @click.prevent="create">Create</button>
    </b-container>
  </div>
</template>
<script>
export default {
  data() {
    return {
      name: null,
      code: null,
      courses: [],
    };
  },
  created() {
    this.$axios.$get("/api/courses").then((courses) => {
      this.courses = courses;
    });
  },
  methods: {
    create() {
      this.$axios
        .$post("/api/courses", {
          code: this.code,
          name: this.name,
        })
        .then(() => {
          this.$router.push("/courses");
          alert("Course created with success!");
        });
    },
  },
};
</script>
