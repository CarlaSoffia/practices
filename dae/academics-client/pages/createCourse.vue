<template>
  <div>
      <form @submit.prevent="create">
        <div>code: <input v-model="code" type="number" min="1"/></div>
        <div>name: <input v-model="name" type="text" /></div>
        <nuxt-link to="/">Return</nuxt-link>
        <button type="reset">RESET</button>
        <button @click.prevent="create">CREATE</button>
      </form>
  </div>
</template>
<script>
export default {
  data() {
    return {
      name: null,
      code: null,
      courses: [],
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
        .$post("/api/courses", {
          code: this.code,
          name: this.name,
        })
        .then(() => {
          this.$router.push("/");
        });
    },
  },
};
</script>
