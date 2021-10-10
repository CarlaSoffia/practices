<template>
  <b-container>
    <h4>Course Details:</h4>
    <p>Code: {{ course.code }}</p>
    <p>Name: {{ course.name }}</p>
    <h4>Subjects enrolled:</h4>
    <b-table
      v-if="subjects.length"
      striped
      over
      :items="subjects"
      :fields="subjectFields"
    />
    <p v-else>This course has no subjects. [NOT IMPLEMENTED]</p>
     <nuxt-link to="/"><img
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
      course: {},
      subjects: [],
      subjectFields: [
        "code",
        "name",
        "courseCode",
        "courseYear",
        "scholarYear",
      ],
    };
  },
  computed: {
    code() {
      return this.$route.params.code;
    },
  },
  created() {
    this.$axios
      .$get(`/api/courses/${this.code}`)
      .then((course) => (this.course = course || {}))
      .then(() => this.$axios.$get(`/api/courses/${this.code}/subjects`))
      .then((subjects) => (this.subjects = subjects));
  },
};
</script>
