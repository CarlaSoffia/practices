<template>
  <b-container>
    <h4>Subject Details:</h4>
    <p>Code: {{ subject.code }}</p>
    <p>Name: {{ subject.name }}</p>
    <p>Course: {{ subject.courseName }}</p>
    <p>Scholar Year: {{ subject.scholarYear }}</p>
    <p>Course Year: {{ subject.courseYear }}</p>
    <h4>Students enrolled:</h4>
    <b-table
      v-if="students.length"
      striped
      over
      :items="students"
      :fields="studentsTeacherFields"
    ></b-table>
    <p v-else>Subject has no students enrolled</p>
    <h4>Teachers enrolled:</h4>
    <b-table
      v-if="teachers.length"
      striped
      over
      :items="teachers"
      :fields="studentsTeacherFields"
    ></b-table>
    <p v-else>Subject has no teachers associated</p>
    <nuxt-link to="/subjects"
      ><img
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
      subject: {},
      students: [],
      studentsTeacherFields: ["name", "email"],
      teachers: [],
    };
  },
  computed: {
    code() {
      return this.$route.params.code;
    },
  },
  created() {
    this.$axios
      .$get(`/api/subjects/${this.code}`)
      .then((subject) => (this.subject = subject || {}));

    this.$axios
      .$get(`/api/subjects/${this.code}/students`)
      .then((students) => (this.students = students || {}));
    this.$axios
      .$get(`/api/subjects/${this.code}/teachers`)
      .then((teachers) => (this.teachers = teachers || {}));
  },
};
</script>
