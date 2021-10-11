<template>
  <b-container>
    <h4>Subject Details:</h4>
    <p>Code: {{ subject.code }}</p>
    <p>Name: {{ subject.name }}</p>
    <p>Course: {{ subject.courseName }}</p>
    <p>Scholar Year: {{ subject.scholarYear }}</p>
    <p>Course Year: {{ subject.courseYear }}</p>

     <nuxt-link to="/subjects"><img
              src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
              alt="update"
              width="25"
              height="25"
      /></nuxt-link>
  </b-container>
</template>
<script>
export default {
  data() {
    return {
      subject: {}
    }
  },
  computed: {
    code() {
      return this.$route.params.code;
    },
  },
  created() {
    this.$axios
      .$get(`/api/subjects/${this.code}`)
      .then((subject) => (this.subject = subject || {}))
  },
};
</script>
