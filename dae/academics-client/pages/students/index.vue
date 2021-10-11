<template>
  <div>
    <b-container>
      <h2>Students</h2>
      <b-table striped over :items="students" :fields="fieldsStudents">
        <template v-slot:cell(details)="row">
          <nuxt-link class="btn btn-link" :to="`/students/${row.item.username}`">
            <img
              src="https://cdn-icons-png.flaticon.com/512/1150/1150592.png"
              alt="view"
              width="25"
              height="25"
            />
          </nuxt-link>
        </template>
        <template v-slot:cell(update)="row">
          <button class="btn btn-link" @click="showHideForm(row.item.username)">
            <img
              src="https://cdn-icons-png.flaticon.com/512/833/833275.png"
              alt="update"
              width="25"
              height="25"
            />
          </button>
        </template>
        <template v-slot:cell(delete)="row">
          <button
            class="btn btn-link"
            @click.prevent="deleteStudent(row.item.username)"
          >
            <img
              src="https://cdn-icons-png.flaticon.com/512/447/447047.png"
              alt="update"
              width="25"
              height="25"
            />
          </button>
        </template>
      </b-table><br>
      <div class="d-flex justify-content-between">
        <nuxt-link to="/"
          ><img
            src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
            alt="update"
            width="25"
            height="25"
        /></nuxt-link>
        <nuxt-link to="/createStudent" class="btn btn-info"
          >Create a New Student</nuxt-link
        >
      </div>
    </b-container><br>
    <b-container
      v-if="updateClicked"
      class="form-group w-50"
      style="margin-left: 75px"
    >
      <h4>Update Student: {{ studentUsername }}</h4>
      <label for="name">Name</label>
      <input v-model="name" type="text" class="form-control" />
      <label for="password">Password</label>
      <input v-model="password" type="password" class="form-control" />
      <label for="email">Email</label>
      <input v-model="email" type="email" class="form-control" />
      <label for="course">Course</label>
       <select class="form-control" v-model="courseCode">
        <template v-for="course in courses">
          <option :key="course.code" :value="course.code">
            {{ course.name }}
          </option>
        </template>
      </select><br>
      <button class="btn btn-info" @click.prevent="updateStudent()">
        Submit
      </button>
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
        "details",
        "update",
        "delete",
      ],
      students: [],
      updateClicked: false,
      studentUsername: null,
      name: "",
      password: "",
      email: "",
      courseCode: "",
      courses: []
    };
  },
  methods: {
    deleteStudent(username) {
      this.$axios.$delete(`/api/students/${username}`).then((student) => {
        alert(`Student ${student.name} removed!`);
      });
    },
    showHideForm(username) {
      this.studentUsername = this.studentUsername == username ? null : username;
      this.updateClicked = !this.updateClicked;
    },

    updateStudent() {
      let updateData = { name: "", password: "", email: "", courseCode: "" };
      if (
        this.name == "" &&
        this.password == "" &&
        this.email == "" &&
        this.courseCode == ""
      ) {
        alert("All fields are empty!");
        return;
      }
      if (this.name == "") {
        this.$delete(updateData, "name");
      } else {
        updateData.name = this.name;
      }
      if (this.password == "") {
        this.$delete(updateData, "password");
      } else {
        updateData.password = this.password;
      }
      if (this.email == "") {
        this.$delete(updateData, "email");
      } else {
        updateData.email = this.email;
      }
      if (this.courseCode == "") {
        this.$delete(updateData, "courseCode");
      } else {
        updateData.courseCode = this.courseCode;
      }

      this.$axios
        .$put(`/api/students/${this.studentUsername}`, updateData)
        .then((student) => {
          alert(`Student ${student.name}  updated!`);
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
