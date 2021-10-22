<template>
  <div>
    <b-container>
      <h2>Courses</h2>
      <b-table striped over :items="courses" :fields="fieldsCourses">
        <template v-slot:cell(details)="row">
          <nuxt-link class="btn btn-link" :to="`/courses/${row.item.code}`">
            <img
              src="https://cdn-icons-png.flaticon.com/512/1150/1150592.png"
              alt="view"
              width="25"
              height="25"
            />
          </nuxt-link>
        </template>
        <template v-slot:cell(update)="row">
          <button class="btn btn-link" @click="showHideForm(row.item.code)">
            <img
              src="https://cdn-icons-png.flaticon.com/512/833/833275.png"
              alt="update"
              width="25"
              height="25"
            />
          </button>
        </template>
        <template v-slot:cell(delete)="row">
          <button  class="btn btn-link" @click.prevent="deleteCourse(row.item.code)">
            <img
              src="https://cdn-icons-png.flaticon.com/512/447/447047.png"
              alt="update"
              width="25"
              height="25"
            />
          </button>
        </template>
      </b-table>
      <br />
      <div class="d-flex justify-content-between">
        <nuxt-link to="/"
          ><img
            src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
            alt="update"
            width="25"
            height="25"
        /></nuxt-link>
        <nuxt-link to="/createCourse" class="btn btn-info"
          >Create a New Course</nuxt-link
        >
      </div> </b-container
    ><br />
    <b-container
      v-if="updateClicked"
      class="form-group w-50"
      style="margin-left: 75px"
    >
      <h4>Update Course: {{ courseCode }}</h4>
      <label for="name">Name</label>
      <input v-model="name" type="text" class="form-control" />
      <br />
      <button class="btn btn-dark" @click="errorMsg = false" type="reset">
        Reset
      </button>
      <button class="btn btn-info" @click.prevent="updateCourse()">
        Submit
      </button>
    </b-container>
  </div>
</template>
<script>
export default {
  data() {
    return {
      fieldsCourses: ["code", "name", "details", "update", "delete"],
      courses: [],
      courseCode: null,
      updateClicked: false,
      name: "",
      errorMsg: false,
    };
  },
  methods: {
    showHideForm(code) {
      this.courseCode = this.courseCode == code ? null : code;
      this.updateClicked = !this.updateClicked;
    },
    deleteCourse(code) {
      this.$axios.$delete(`/api/courses/${code}`).then((course) => {
        alert(`Course ${course.name} removed!`);
      });
    },
    updateCourse() {
      let updateData = { name: "" };
      if (this.name == "") {
        alert("All fields are empty!");
        return;
      }
      updateData.name = this.name;

      this.$axios
        .$put(`/api/courses/${this.courseCode}`, updateData)
        .then((course) => {
          alert(`Course ${course.name}  updated!`);
        })
        .catch((error) => {
          this.errorMsg = error.response.data;
        });
    },
  },
  created() {
    this.$axios.$get("/api/courses/").then((courses) => {
      this.courses = courses;
    });
  },
};
</script>
<style></style>
