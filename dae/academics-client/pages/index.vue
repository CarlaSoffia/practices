<template>
  <div>
    <b-container>
      <h2>Students</h2>
      <b-table striped over :items="students" :fields="fieldsStudents" />
      <nuxt-link to="/createStudent">Create a New Student</nuxt-link>
    </b-container>
    <br />
    <b-container>
      <h2>Courses</h2>
      <b-table striped over :items="courses" :fields="fieldsCourses" />
      <nuxt-link to="/createCourse">Create a New Course</nuxt-link>
      <br /><br />
      <form>
        <h3>Update/Delete Course</h3>
        <select v-model="code">
          <template v-for="course in courses">
            <option :key="course.code" :value="course.code">
              {{ course.name }}
            </option>
          </template>
        </select>
        <input v-model="name" placeholder="Course name" type="text" />
        <button @click.prevent="updateCourse(code)">
          <img
            src="https://cdn-icons-png.flaticon.com/512/833/833275.png"
            alt="update"
            width="25"
            height="25"
          />
        </button>
        <button @click.prevent="deleteCourse()">
          <img
            src="https://cdn-icons-png.flaticon.com/512/84/84493.png"
            alt="update"
            width="25"
            height="25"
          />
        </button>
      </form>
    </b-container>
  </div>
</template>
<script>
export default {
  data() {
    return {
      fieldsStudents: ["name", "password", "username", "email", "courseCode"],
      students: [],
      fieldsCourses: ["code", "name"],
      courses: [],
      codeDelete: "",
      codeUpdate: "",
      name: null,
      code: null,
    };
  },
  methods: {
    deleteCourse() {
      if (this.code == null) {
        alert("No Course was selected!");
        return;
      }
      this.$axios
        .$delete(`http://localhost:8080/academics/api/courses/${this.code}`)
        .then((course) => {
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
        .$put(`http://localhost:8080/academics/api/courses/${this.code}`, {
          name: this.name
        })
        .then(() => {
          alert("Course updated!");
          this.code = null;
          this.name = null;
        });
    },
  },
  created() {
    this.$axios
      .$get("http://localhost:8080/academics/api/students/")
      .then((students) => {
        this.students = students;
      });

    this.$axios
      .$get("http://localhost:8080/academics/api/courses/")
      .then((courses) => {
        this.courses = courses;
      });
  },
};
</script>
<style></style>
