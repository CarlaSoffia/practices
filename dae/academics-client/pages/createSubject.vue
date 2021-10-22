<template>
  <div>
    <b-container
      class="form-group w-50"
      style="margin-left: 75px"
      @submit.prevent="create"
    >
      <h4>Create new Subject</h4>
      <div>
        Code:
        <input v-model="code" type="number" min="1" class="form-control" />
      </div>
      <div>Name: <input v-model="name" type="text" class="form-control" /></div>
      <div>
        Course Year:
        <input
          v-model="courseYear"
          type="number"
          min="1"
          class="form-control"
        />
      </div>
      <div>
        Scholar Year:
        <input
          v-model="scholarYear"
          type="number"
          min="1"
          class="form-control"
        />
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
       <p v-show="errorMsg" class="text-danger">
        {{ errorMsg }}
      </p>
      <div class="d-flex justify-content-between">
        <nuxt-link to="/subjects"
          ><img
            src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
            alt="update"
            width="25"
            height="25"
        /></nuxt-link>
        <div class="d-flex">
          <button
            class="btn btn-dark mr-1"
            @click="errorMsg = false"
            type="reset"
          >
            Reset
          </button>
          <button class="btn btn-info ml-1" @click.prevent="create">
            Create
          </button>
        </div>
      </div>
    </b-container>
  </div>
</template>
<script>
export default {
  data() {
    return {
      name: null,
      code: null,
      courseCode: null,
      scholarYear: null,
      courseYear: null,
      errorMsg: false,
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
        .$post("/api/subjects", {
          code: this.code,
          name: this.name,
          courseCode: this.courseCode,
          scholarYear: this.scholarYear,
          courseYear: this.courseYear,
        })
        .then(() => {
          this.$router.push("/subjects");
          alert("Subject created with success!");
        })
        .catch((error) => {
          this.errorMsg = error.response.data;
        });
    },
  },
};
</script>
