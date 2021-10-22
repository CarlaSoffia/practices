<template>
  <div>
    <b-container
      class="form-group w-50"
      style="margin-left: 75px"
      @submit.prevent="create"
    >
      <h4>Create new Teacher</h4>
      <div>
        Username: <input v-model="username" type="text" class="form-control" />
      </div>
      <div>
        Password:
        <input v-model="password" type="password" class="form-control" />
      </div>
      <div>Name: <input v-model="name" class="form-control" type="text" /></div>
      <div>
        Email: <input v-model="email" class="form-control" type="email" />
      </div>
      <div>
        Office: <input v-model="office" class="form-control" type="text" />
      </div>
      <br />
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
          <button class="btn btn-info ml-1" @click.prevent="create">
            Create
          </button>
        </div>
      </div>
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
};
</script>
