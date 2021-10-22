<template>
  <div>
    <b-container>
      <h2>Subjects</h2>
      <b-table striped over :items="subjects" :fields="fieldsSubjects">
        <template v-slot:cell(details)="row">
          <nuxt-link class="btn btn-link" :to="`/subjects/${row.item.code}`">
            <img
              src="https://cdn-icons-png.flaticon.com/512/1150/1150592.png"
              alt="view"
              width="25"
              height="25"
            />
          </nuxt-link>
        </template>
        <template v-slot:cell(update)="row">
          <button class="btn btn-link" @click="showHideForm(row.item.code)">
            <img
              src="https://cdn-icons-png.flaticon.com/512/833/833275.png"
              alt="update"
              width="25"
              height="25"
            />
          </button>
        </template>
        <template v-slot:cell(delete)="row">
          <button class="btn btn-link"  @click.prevent="deleteSubject(row.item.code)">
            <img
              src="https://cdn-icons-png.flaticon.com/512/447/447047.png"
              alt="update"
              width="25"
              height="25"
            />
          </button>
        </template>
      </b-table>
      <br />
      <div class="d-flex justify-content-between">
        <nuxt-link to="/"
          ><img
            src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
            alt="update"
            width="25"
            height="25"
        /></nuxt-link>
        <nuxt-link to="/createSubject" class="btn btn-info"
          >Create a New Subject</nuxt-link
        >
      </div> </b-container
    ><br />
    <b-container
      v-if="updateClicked"
      class="form-group w-50"
      style="margin-left: 75px"
    >
      <h4>Update Subject: {{ subjectCode }}</h4>
      <label>Name</label>
      <input v-model="name" type="text" class="form-control" />
      <label>Course Year</label>
      <input v-model="courseYear" type="number" min="1" class="form-control" />
      <label>Scholar Year</label>
      <input v-model="scholarYear" type="number" min="1" class="form-control" />
      <label>Course code</label>
      <select class="form-control" v-model="courseCode">
        <template v-for="course in courses">
          <option :key="course.code" :value="course.code">
            {{ course.name }}
          </option>
        </template>
      </select>
      <br />
      <button class="btn btn-dark" @click="errorMsg = false" type="reset">
        Reset
      </button>
      <button class="btn btn-info" @click.prevent="updateSubject()">
        Submit
      </button>
    </b-container>
  </div>
</template>
<script>
export default {
  data() {
    return {
      fieldsSubjects: [
        "code",
        "name",
        "courseName",
        "details",
        "update",
        "delete",
      ],
      subjects: [],
      subjectCode: null,
      updateClicked: false,
      name: "",
      courses: [],
      courseYear: "",
      scholarYear: "",
      errorMsg: false,
    };
  },
  methods: {
    showHideForm(code) {
      this.subjectCode = this.subjectCode == code ? null : code;
      this.updateClicked = !this.updateClicked;
    },
    deleteSubject(code) {
      this.$axios.$delete(`/api/subjects/${code}`).then((subject) => {
        alert(`Subject ${subject.name} removed!`);
      });
    },
    updateSubject() {
      let updateData = {
        name: "",
        courseCode: "",
        courseYear: "",
        scholarYear: "",
      };
      if (
        this.name == "" &&
        this.courseYear == "" &&
        this.scholarYear == "" &&
        this.courseCode == ""
      ) {
        alert("All fields are empty!");
        return;
      }
      if (this.name == "") {
        this.$delete(updateData, "name");
      } else {
        updateData.name = this.name;
      }
      if (this.courseYear == "") {
        this.$delete(updateData, "courseYear");
      } else {
        updateData.courseYear = this.courseYear;
      }
      if (this.scholarYear == "") {
        this.$delete(updateData, "scholarYear");
      } else {
        updateData.scholarYear = this.scholarYear;
      }
      if (this.courseCode == "") {
        this.$delete(updateData, "courseCode");
      } else {
        updateData.courseCode = this.courseCode;
      }

      updateData.name = this.name;

      this.$axios
        .$put(`/api/subjects/${this.subjectCode}`, updateData)
        .then((subject) => {
          alert(`Subject ${subject.name}  updated!`);
        })
        .catch((error) => {
          this.errorMsg = error.response.data;
        });
    },
  },
  created() {
    this.$axios.$get("/api/subjects/").then((subjects) => {
      this.subjects = subjects;
    });
    this.$axios.$get("/api/courses/").then((courses) => {
      this.courses = courses;
    });
  },
};
</script>
<style></style>
