<template>
  <div>
    <b-container>
      <h2>Teachers</h2>
      <b-table striped over :items="teachers" :fields="fieldsTeachers">
        <template v-slot:cell(details)="row">
          <nuxt-link
            class="btn btn-link"
            :to="`/teachers/${row.item.username}`"
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
            @click.prevent="deleteTeacher(row.item.username)"
          >
            <img
              src="https://cdn-icons-png.flaticon.com/512/447/447047.png"
              alt="update"
              width="25"
              height="25"
            />
          </button>
        </template> </b-table
      ><br />
      <div class="d-flex justify-content-between">
        <nuxt-link to="/"
          ><img
            src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
            alt="update"
            width="25"
            height="25"
        /></nuxt-link>
        <nuxt-link to="/createTeacher" class="btn btn-info"
          >Create a New Teacher</nuxt-link
        >
      </div> </b-container
    ><br />
    <b-container
      v-if="updateClicked"
      class="form-group w-50"
      style="margin-left: 75px"
    >
      <h4>Update Teacher: {{ teacherUsername }}</h4>
      <label for="name">Name</label>
      <input v-model="name" type="text" class="form-control" />
      <label for="password">Password</label>
      <input v-model="password" type="password" class="form-control" />
      <label for="email">Email</label>
      <input v-model="email" type="email" class="form-control" />
      <label for="office">Office</label>
      <input v-model="office" type="text" class="form-control" /><br />
      <button class="btn btn-dark" @click="errorMsg = false" type="reset">
        Reset
      </button>
      <button class="btn btn-info" @click.prevent="updateTeacher()">
        Submit
      </button>
    </b-container>
  </div>
</template>
<script>
export default {
  data() {
    return {
      fieldsTeachers: [
        "username",
        "name",
        "email",
        "Office",
        "details",
        "update",
        "delete",
      ],
      teachers: [],
      updateClicked: false,
      teacherUsername: null,
      name: "",
      password: "",
      email: "",
      office: "",
      errorMsg: false,
    };
  },
  methods: {
    deleteTeacher(username) {
      this.$axios.$delete(`/api/teachers/${username}`).then((teacher) => {
        alert(`Teacher ${teacher.name} removed!`);
      });
    },
    showHideForm(username) {
      this.teacherUsername = this.teacherUsername == username ? null : username;
      this.updateClicked = !this.updateClicked;
    },

    updateTeacher() {
      let updateData = { name: "", password: "", email: "", office: "" };
      if (
        this.name == "" &&
        this.password == "" &&
        this.email == "" &&
        this.office == ""
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
      if (this.office == "") {
        this.$delete(updateData, "office");
      } else {
        updateData.office = this.office;
      }

      this.$axios
        .$put(`/api/teachers/${this.teacherUsername}`, updateData)
        .then((teacher) => {
          alert(`Teacher ${teacher.name}  updated!`);
        })
        .catch((error) => {
          this.errorMsg = error.response.data;
        });
    },
  },
  created() {
    this.$axios.$get("/api/teachers/").then((teachers) => {
      this.teachers = teachers;
    });
  },
};
</script>
<style></style>
