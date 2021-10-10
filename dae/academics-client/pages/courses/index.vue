<template>
  <div>
    <b-container>
      <h2>Courses</h2>
      <b-table striped over :items="courses" :fields="fieldsCourses">
        <template v-slot:cell(details)="row">
          <nuxt-link class="btn btn-link" :to="`/courses/${row.item.code}`"
            ><img
            src="https://cdn-icons-png.flaticon.com/512/1150/1150592.png"
            alt="view"
            width="25"
            height="25"
          /></nuxt-link
          >
        </template>
        <template v-slot:cell(update)="row">
          <nuxt-link class="btn btn-link" :to="`/courses/${row.item.code}`"
            ><img
              src="https://cdn-icons-png.flaticon.com/512/833/833275.png"
              alt="update"
              width="25"
              height="25"
          /></nuxt-link>
        </template>
        <template v-slot:cell(delete)="row">
          <button @click.prevent="deleteCourse(row.item.code)"
            ><img
              src="https://cdn-icons-png.flaticon.com/512/447/447047.png"
              alt="update"
              width="25"
              height="25"
          /></button>
        </template>
      </b-table>
      <div class="d-flex justify-content-between">
        <nuxt-link to="/"><img
              src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
              alt="update"
              width="25"
              height="25"
      /></nuxt-link>
      <nuxt-link to="/createCourse" class="btn btn-info">Create a New Course</nuxt-link>
      </div>

    </b-container>
  </div>
</template>
<script>
export default {
  data() {
    return {
      fieldsCourses: ["code", "name", "details", "update", "delete"],
      courses: [],
      name: null,
      HTMLCourse: "",
    };
  },
  methods: {
    deleteCourse(code) {
      this.$axios.$delete(`/api/courses/${code}`).then((course) => {
        alert(`Course ${course.name} removed!`);
      });
    },
    updateCourse() {
      if (this.code == null) {
        alert("No Course was selected!");
        return;
      }
      if (this.name == null || this.name == "") {
        alert("Course name is empty!");
        return;
      }

      this.$axios
        .$put(`/api/courses/${this.code}`, {
          name: this.name,
        })
        .then(() => {
          alert("Course updated!");
          this.code = null;
          this.name = null;
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
