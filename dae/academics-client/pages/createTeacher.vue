<template>
    <b-container>
      <h4>Create new Teacher</h4>
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
        Office: <input v-model.trim="office" class="form-control" type="text" :state="isOfficeValid" required placeholder="Enter your office"/>
         <p>{{isOfficeValidFeedback}}</p>
      </div>
      <br>
      <p v-show="errorMsg" class="text-danger">
        {{ errorMsg }}
      </p>
      <div class="d-flex justify-content-between">
        <nuxt-link to="/teachers"
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
          <button class="btn btn-info ml-1" @click.prevent="create" :disabled="!isFormValid">
            Create
          </button>
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
      office: null,
      errorMsg: false,
    };
  },
  methods: {
    create() {
      this.$axios
        .$post("/api/teachers", {
          username: this.username,
          password: this.password,
          name: this.name,
          email: this.email,
          office: this.office,
        })
        .then(() => {
          this.$router.push("/teachers");
          alert("Teacher created with success!");
        })
        .catch((error) => {
          this.errorMsg = error.response.data;
        });
    },
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
     isOfficeValidFeedback(){
       if (!this.office) {
          return null
        }
        let officeLen = this.office.length
        if (officeLen < 3 || officeLen > 15) {
           return 'Office: "'+this.office+'" is too short, lenght must be between 3 and 15'
        }
        return ''
    },
    isOfficeValid(){
        if (this.isOfficeValidFeedback === null) {
           return null
        }
        return this.isOfficeValidFeedback === ''
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
        if (!this.isOfficeValid) {
           return false
        }
        return true
      }
    }
};
</script>
