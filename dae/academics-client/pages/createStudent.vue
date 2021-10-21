<template>
  <div>
    <b-container
      class="form-group w-50"
      style="margin-left: 75px"
      @submit.prevent="create"
    >
      <h4>Create new Student</h4>
      <div>
        Username: <input v-model="username" type="text" class="form-control" />
      </div>
      <div>
        Password:
        <input v-model="password" type="password" class="form-control" />
      </div>
      <div>Name: <input v-model="name" class="form-control" type="text" /></div>
      <div>
        Email: <input v-model="email" class="form-control" type="email" />
      </div>
      <div>
        Course:
        <select class="form-control" v-model="courseCode">
          <template v-for="course in courses">
            <option :key="course.code" :value="course.code">
              {{ course.name }}
            </option>
          </template>
        </select>
      </div>
      <br />
      <nuxt-link to="/students"
        ><img
          src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
          alt="update"
          width="25"
          height="25"
      /></nuxt-link>
      <p v-show="errorMsg" class="text-danger">
        {{ errorMsg }}
      </p>
      <button class="btn btn-info" @click="errorMsg = false" type="reset">
        Reset
      </button>
      <button class="btn btn-info" @click.prevent="create">Create</button>
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
      errorMsg: false,
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
          alert("Student created with success!");
        })
        .catch((error) => {
          this.errorMsg = error.response.data;
        });
    },
  },
};
</script>
