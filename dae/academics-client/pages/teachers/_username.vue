<template>
  <b-container>
    <h4>Teacher Details:</h4>
    <p>Username: {{ teacher.username }}</p>
    <p>Name: {{ teacher.name }}</p>
    <p>Email: {{ teacher.email }}</p>
    <p>Password: {{ teacher.password }}</p>
    <p>Office: {{ teacher.office }}</p>
    <h4>Subjects associated:</h4>
    <b-table
      v-if="subjects.length"
      striped
      over
      :items="subjects"
      :fields="subjectsFields"
    >
      <template v-slot:cell(dissociate)="row">
        <input
          @click="unCheck($event, row.item.code)"
          type="checkbox"
          :value="row.item.code"
        />
      </template>
    </b-table>
    <p v-else>Teacher is not associated to any Subject</p>
    <button
      v-if="subjects.length"
      class="btn btn-info"
      @click.prevent="dissociateTeacherSubjects()"
    >
      Dissociate
    </button>
    <br /><br />
    <b-container class="form-group">
      <h4>Associate teacher to Course Subjects:</h4>
      <b-table
        v-if="allSubjectsAssociate.length"
        striped
        over
        :items="allSubjectsAssociate"
        :fields="subjectsFieldsAssociate"
      >
        <template v-slot:cell(associate)="row">
          <input
            @click="check($event, row.item.code)"
            type="checkbox"
            :value="row.item.code"
          />
        </template>
      </b-table>
      <p v-else>Teacher associated to all the Course's subject</p>
      <button
        v-if="allSubjectsAssociate.length"
        class="btn btn-info"
        @click.prevent="associateTeacherSubjects()"
      >
        Associate
      </button>
    </b-container>
    <br>
    <nuxt-link to="/teachers"
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
  methods: {
    unCheck: function (evt, code) {
      if (evt.target.checked && !this.subjectsDissociate.includes(code)) {
        this.subjectsDissociate.push(code);
      } else if (
        !evt.target.checked &&
        this.subjectsDissociate.includes(code)
      ) {
        this.subjectsDissociate.splice(
          this.subjectsDissociate.indexOf(code),
          1
        );
      }
    },
    dissociateTeacherSubjects() {
      this.subjectsDissociate.forEach((code) => {
        this.$axios
          .$post(`/api/teachers/${this.username}/dissociate/${code}`)
          .then(() => {
            alert(`Teacher dissociated with success from subject: ${code}`);
          });
      });
      this.$router.push(`/teachers/${this.username}`);
    },
    check: function (evt, code) {
      if (evt.target.checked && !this.subjectsAssociate.includes(code)) {
        this.subjectsAssociate.push(code);
      } else if (!evt.target.checked && this.subjectsAssociate.includes(code)) {
        this.subjectsAssociate.splice(this.subjectsAssociate.indexOf(code), 1);
      }
    },
    associateTeacherSubjects() {
      this.subjectsAssociate.forEach((code) => {
        this.$axios
          .$post(`/api/teachers/${this.username}/associate/${code}`)
          .then(() => {
            alert(`Teacher associated with success in subject: ${code}`);
          });
      });
      this.$router.push(`/teachers/${this.username}`);
    },
  },
  data() {
    return {
      teacher: {},
      subjects: [],
      subjectsFields: ["code", "name", "dissociate"],
      allSubjectsAssociate: [],
      subjectsFieldsAssociate: ["code", "name", "associate"],
      subjectsDissociate: [],
      subjectsAssociate: [],
    };
  },
  computed: {
    username() {
      return this.$route.params.username;
    },
  },
  created() {
    this.$axios
      .$get(`/api/teachers/${this.username}`)
      .then((teacher) => (this.teacher = teacher || {}));

    this.$axios
      .$get(`/api/teachers/${this.username}/subjects`)
      .then((subjects) => {
        this.subjects = subjects || {};
          this.$axios
            .$get(`/api/subjects/`)
            .then((subjectsAll) => {
              this.allSubjectsAssociate = subjectsAll;
              let removed = false;
              for (let i = 0; i < this.allSubjectsAssociate.length; i++) {
                if (removed == true) i = 0;
                removed = false;
                this.subjects.forEach((sub) => {
                  if (sub.code == this.allSubjectsAssociate[i].code) {
                    this.allSubjectsAssociate.splice(i, 1);
                    removed = true;
                    return;
                  }
                });
              }
            });

      });
  },
};
</script>
