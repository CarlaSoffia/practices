<template>
  <div>
    <b-container>
      <h2>Students</h2>
      <b-table striped over :items="students" :fields="fieldsStudents" />
      <nuxt-link to="/createStudent">Create a New Student</nuxt-link>
    </b-container>
    <br>
    <b-container>
      <h2>Courses</h2>
      <b-table striped over :items="courses" :fields="fieldsCourses" />
      <nuxt-link to="/createCourse">Create a New Course</nuxt-link>
      <br>
      <div style="display:flex;flex-direction:row">
        <div>Delete Course | code: <input v-model="codeDelete" type="number" min="1" /></div>
        <div style="margin-left:5px" @click="deleteStudent(codeDelete)">
          <img src="https://cdn-icons-png.flaticon.com/512/84/84493.png" alt="delete" width="25" height="25">
        </div>
      </div>
    </b-container>
    <br><br>
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
      codeDelete: ""
    };
  },
  methods: {
    deleteStudent(codeDelete) {
      const headers = {
            'Content-Type': 'application/json'
        };
      this.$axios.$delete("http://localhost:8080/academics/api/courses/",{headers});
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
