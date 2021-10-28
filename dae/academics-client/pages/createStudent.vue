<template>
    <b-container>
      <h4>Create new Student</h4>
      <form @submit.prevent="create" class="form-group w-50"  :disabled="!isFormValid">
        <div>
        Username: <b-input v-model.trim="username" type="text" class="form-control" :state="isUsernameValid" required placeholder="Enter your username"/>
        <p>{{isUsernameValidFeedback}}</p>
      </div>
      <div>
        Password:
        <b-input v-model="password" type="password" class="form-control"  :state="isPasswordValid" required placeholder="Enter your password"/>
        <p>{{isPasswordValidFeedback}}</p>
      </div>
      <div>Name: <b-input v-model.trim="name" class="form-control" type="text"  :state="isNameValid" required placeholder="Enter your name"/>
       <p>{{isNameValidFeedback}}</p>
      </div>
      <div>
        Email: <b-input v-model.trim="email" ref="email" class="form-control" type="email" :state="isEmailValid" required pattern=".+@my.ipleiria.pt" placeholder="Enter your e-mail"/>
       <p>{{isEmailValidFeedback}}</p>
      </div>
      <div>
        Course:
        <b-select v-model="courseCode" :options="courses" :state="isCourseValid" required value-field="code" text-field="name">
            <template v-slot:first>
                <option :value="null" disabled>-- Please select the Course --</option>
            </template>
        </b-select>
      </div>
      <br>

      <p v-show="errorMsg" class="text-danger">
        {{ errorMsg }}
      </p>
      <div class="d-flex justify-content-between">
        <nuxt-link to="/students"
          ><img
            src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
            alt="update"
            width="25"
            height="25"
        /></nuxt-link>
        <div class="d-flex">
          <button class="btn btn-dark mr-1" @click="errorMsg = false" type="reset">
            Reset
          </button>
          <button class="btn btn-info ml-1" @click.prevent="create" :disabled="!isFormValid">Create</button>
        </div>
      </div>
      </form>
    </b-container>
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
    reset () {
        this.errorMsg = false
    }
  },
  computed:{
    isUsernameValidFeedback(){
        if (!this.username) {
            return null
        }
        let usernameLen = this.username.length
        if (usernameLen < 3 || usernameLen > 15) {
           return 'Username: "'+this.username+'" is too short, lenght must be between 3 and 15'
        }
        return ''
    },
    isUsernameValid () {
        if (this.isUsernameValidFeedback === null) {
           return null
        }
        return this.isUsernameValidFeedback === ''
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
    isCourseValid () {
        if (!this.courseCode) {
            return null
        }
       return this.courses.some(course => this.courseCode === course.code)
    },
  isFormValid () {
    if (!this.isUsernameValid) {
      return false
    }
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
}
</script>
