<template>
<div>
  <b-container class="form-group w-50"
      style="margin-left: 75px" @submit.prevent="create">
    <h4>Create new Administrator</h4>
    <div>Username: <input v-model="username" type="text" class="form-control" /></div>
    <div>Password: <input v-model="password" type="password" class="form-control"/></div>
    <div>Name: <input v-model="name" class="form-control" type="text" /></div>
    <div>Email: <input v-model="email" class="form-control" type="email" /></div>
    <br>
     <nuxt-link to="/administrators"
          ><img
            src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
            alt="update"
            width="25"
            height="25"
        /></nuxt-link>
    <button class="btn btn-info" type="reset">Reset</button>
    <button class="btn btn-info" @click.prevent="create">Create</button>
  </b-container>
  </div>
</template>
<script>
export default {
  data() {
    return {
      username: null,
      password: null,
      name: null,
      email: null
    };
  },
  methods: {
    create() {
      this.$axios
        .$post("/api/administrators", {
          username: this.username,
          password: this.password,
          name: this.name,
          email: this.email
        })
        .then(() => {
          this.$router.push("/administrators");
          alert("Administrator created with success!");
        });
    },
  },
};
</script>
