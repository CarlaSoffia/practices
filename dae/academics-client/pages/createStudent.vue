<template>
<div>
  <b-container class="form-group w-50"
      style="margin-left: 75px" @submit.prevent="create">
    <div>username: <input v-model="username" type="text" class="form-control" /></div>
    <div>password: <input v-model="password" type="password" class="form-control"/></div>
    <div>name: <input v-model="name" class="form-control" type="text" /></div>
    <div>email: <input v-model="email" class="form-control" type="email" /></div>
    <div>
      course code:
      <select class="form-control" v-model="courseCode">
        <template v-for="course in courses">
          <option :key="course.code" :value="course.code">
            {{ course.name }}
          </option>
        </template>
      </select>
    </div>
    <nuxt-link to="/">Return</nuxt-link>
    <button class="btn btn-info" type="reset">RESET</button>
    <button class="btn btn-info" @click.prevent="create">CREATE</button>
  </b-container>
  </div>
</template>
<script>
export default {
  data() {
    return {
      username: null,
      password: null,
      name: null,
      email: null,
      courseCode: null,
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
        .$post("/api/students", {
          username: this.username,
          password: this.password,
          name: this.name,
          email: this.email,
          courseCode: this.courseCode,
        })
        .then(() => {
          this.$router.push("/students");
          alert("Student created with sucess!");
        });
    },
  },
};
</script>
