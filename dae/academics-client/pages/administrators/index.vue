<template>
  <div>
    <b-container>
      <h2>Administrators</h2>
      <b-table
        striped
        over
        :items="administrators"
        :fields="fieldsAdministrators"
      >
        <template v-slot:cell(details)="row">
          <nuxt-link
            class="btn btn-link"
            :to="`/administrators/${row.item.username}`"
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
            @click.prevent="deleteAdministrator(row.item.username)"
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
        <nuxt-link to="/createAdministrator" class="btn btn-info"
          >Create a New Administrator</nuxt-link
        >
      </div> </b-container
    ><br />
    <b-container
      v-if="updateClicked"
      class="form-group w-50"
      style="margin-left: 75px"
    >
      <h4>Update Administrator: {{ administratorUsername }}</h4>
      <label for="name">Name</label>
      <input v-model="name" type="text" class="form-control" />
      <label for="password">Password</label>
      <input v-model="password" type="password" class="form-control" />
      <label for="email">Email</label>
      <input v-model="email" type="email" class="form-control" />
      <br />
      <p v-show="errorMsg" class="text-danger">
        {{ errorMsg }}
      </p>
      <button class="btn btn-dark" @click="errorMsg = false" type="reset">
        Reset
      </button>
      <button class="btn btn-info" @click.prevent="updateAdministrator()">
        Submit
      </button>
    </b-container>
  </div>
</template>
<script>
export default {
  data() {
    return {
      fieldsAdministrators: [
        "username",
        "name",
        "email",
        "details",
        "update",
        "delete",
      ],
      administrators: [],
      updateClicked: false,
      administratorUsername: null,
      name: "",
      password: "",
      email: "",
      errorMsg: false,
    };
  },
  methods: {
    deleteAdministrator(username) {
      this.$axios
        .$delete(`/api/administrators/${username}`)
        .then((administrator) => {
          alert(`Administrator ${administrator.name} removed!`);
        });
    },
    showHideForm(username) {
      this.administratorUsername =
        this.administratorUsername == username ? null : username;
      this.updateClicked = !this.updateClicked;
    },

    updateAdministrator() {
      let updateData = { name: "", password: "", email: "" };
      if (this.name == "" && this.password == "" && this.email == "") {
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
      this.$axios
        .$put(`/api/administrators/${this.administratorUsername}`, updateData)
        .then((administrator) => {
          alert(`Administrator ${administrator.name}  updated!`);
        })
        .catch((error) => {
          this.errorMsg = error.response.data;
        });
    },
  },
  created() {
    this.$axios.$get("/api/administrators/").then((administrators) => {
      this.administrators = administrators;
    });
  },
};
</script>
<style></style>
