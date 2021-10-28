<template>
  <div>
    <b-container>
      <h2>Students</h2>
      <b-table striped over :items="students" :fields="fieldsStudents">
        <template v-slot:cell(details)="row">
          <nuxt-link
            class="btn btn-link"
            :to="`/students/${row.item.username}`"
          >
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
        <template v-slot:cell(sendEmail)="row">
          <nuxt-link :to="`/students/${row.item.username}/send-email`"><img
              src="https://cdn-icons-png.flaticon.com/512/116/116340.png"
              alt="email"
              width="25"
              height="25"
            /></nuxt-link>
        </template>
           </b-table
      ><br>
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
      </div> </b-container
    ><br>
    <b-container>
      <h4>Update Student: {{ studentUsername }}</h4>
      <form @submit.prevent="create" class="form-group w-50"  :disabled="!isFormValid">
      <label for="name">Name</label>
      <b-input v-model.trim="name" type="text" class="form-control" :state="isNameValid" required placeholder="Enter your name" />
      <p>{{isNameValidFeedback}}</p>
      <label for="password">Password</label>
      <b-input v-model="password" type="password" class="form-control"  :state="isPasswordValid" required placeholder="Enter your password"/>
      <p>{{isPasswordValidFeedback}}</p>
      <label for="email">Email</label>
      <b-input v-model.trim="email" ref="email" type="email" class="form-control" :state="isEmailValid" required pattern=".+@my.ipleiria.pt" placeholder="Enter your e-mail"/>
      <p>{{isEmailValidFeedback}}</p>
      <label for="course">Course</label>
       <b-select v-model="courseCode" :options="courses" :state="isCourseValid" required value-field="code" text-field="name">
            <template v-slot:first>
                <option :value="null" disabled>-- Please select the Course --</option>
            </template>
        </b-select><br><br>
      <button class="btn btn-dark" @click="errorMsg = false" type="reset">
        Reset
      </button>
      <button class="btn btn-info" @click.prevent="updateStudent()" :disabled="!isFormValid">
        Submit
      </button>
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
        "details",
        "update",
        "delete",
        "sendEmail"
      ],
      students: [],
      updateClicked: false,
      studentUsername: null,
      name: "",
      password: "",
      email: "",
      courseCode: "",
      courses: [],
      errorMsg: false,
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
        })
        .catch((error) => {
          this.errorMsg = error.response.data;
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
  computed:{
    isNameValidFeedback (){
        if (!this.name) {
          return null
        }
        let nameLen = this.name.length
        if (nameLen < 3 || nameLen > 25) {
           return 'Name: "'+this.name+'" is too short, lenght must be between 3 and 25'
        }
        return ''
    },
    isNameValid () {
        if (this.isNameValidFeedback === null) {
           return null
        }
        return this.isNameValidFeedback === ''
    },
    isEmailValidFeedback () {
        if (!this.email) {
          return null
        }
        return this.$refs.email.checkValidity() ? '':'Email is not valid, domain must be my.ipleiria.pt'
    },
    isEmailValid () {
        if (this.isEmailValidFeedback === null) {
          return null
        }
        return this.isEmailValidFeedback === ''
    },
     isPasswordValidFeedback () {
        if (!this.password) {
           return null
        }
        let passwordLen = this.password.length
        if (passwordLen < 3 || passwordLen > 255) {
          return 'Password is too short, lenght must be between 3 and 255'
        }
        return ''
    },
    isPasswordValid () {
        if (this.isPasswordValidFeedback === null) {
           return null
        }
        return this.isPasswordValidFeedback === ''
    },
    isCourseValid () {
        if (!this.courseCode) {
            return null
        }
       return this.courses.some(course => this.courseCode === course.code)
    },
     isFormValid () {
    if (!this.isPasswordValid) {
      return false
    }
    if (!this.isNameValid) {
      return false
    }
    if (!this.isEmailValid) {
      return false
    }
    if (!this.isCourseValid) {
      return false
    }
      return true
    }
  }
};
</script>
<style></style>
