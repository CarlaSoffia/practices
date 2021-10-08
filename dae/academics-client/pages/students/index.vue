<template>
  <div>
    <b-container>
      <h2>Students</h2>
      <b-table striped over :items="students" :fields="fieldsStudents">
        <template v-slot:cell(actions)="row">
          <nuxt-link class="btn btn-link" :to="`/students/${row.item.username}`"
            >Details</nuxt-link
          >
        </template>
      </b-table>
      <nuxt-link to="/">Back</nuxt-link>
    </b-container>
    <br />
    <b-container>
      <h2>Courses</h2>
      <b-table striped over :items="courses" :fields="fieldsCourses" />
      <nuxt-link to="/createCourse">Create a New Course</nuxt-link>
      <br /><br />
      <form>
        <h3>Update/Delete/View Course</h3>
        <select v-model="code">
          <template v-for="course in courses">
            <option :key="course.code" :value="course.code">
              {{ course.name }}
            </option>
          </template>
        </select>
        <input v-model="name" placeholder="Course name" type="text" />
        <button @click.prevent="updateCourse()">
          <img
            src="https://cdn-icons-png.flaticon.com/512/833/833275.png"
            alt="update"
            width="25"
            height="25"
          />
        </button>
        <button @click.prevent="deleteCourse()">
          <img
            src="https://img-premium.flaticon.com/png/512/657/premium/657059.png?token=exp=1633599757~hmac=0ef5b1c5954a9ae95cf946e75a40d56b"
            alt="update"
            width="25"
            height="25"
          />
        </button>
        <button @click.prevent="viewCourse()">
          <img
            src="https://img-premium.flaticon.com/png/512/1078/premium/1078327.png?token=exp=1633600313~hmac=0416291c19836dc33a2dd6e88386bb5b"
            alt="view"
            width="25"
            height="25"
          />
        </button>
        <div v-html="HTMLCourse"></div>
      </form>
    </b-container>
  </div>
</template>
<script>
export default {
  data() {
    return {
      fieldsStudents: [
        "username",
        "name",
        "email",
        "courseName",
        "actions"
      ],
      students: [],
      fieldsCourses: ["code", "name"],
      courses: [],
      name: null,
      code: null,
      HTMLCourse: "",
    };
  },
  methods: {
    viewCourse() {
      if (this.code == null) {
        alert("No Course was selected!");
        return;
      }
      this.$axios.$get(`/api/courses/${this.code}`).then((course) => {
        this.HTMLcontent = `<h5>Course Info</h5>
          <p>Code: ${course.code}</p>
          <p>Name:  ${course.name}</p>`;
        this.code = null;
      });
    },
    deleteCourse() {
      if (this.code == null) {
        alert("No Course was selected!");
        return;
      }
      this.$axios.$delete(`/api/courses/${this.code}`).then((course) => {
        alert(`Course ${course.name} removed!`);
        this.code = null;
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
    this.$axios.$get("/api/students/").then((students) => {
      this.students = students;
    });

    this.$axios.$get("/api/courses/").then((courses) => {
      this.courses = courses;
    });
  },
};
</script>
<style></style>
