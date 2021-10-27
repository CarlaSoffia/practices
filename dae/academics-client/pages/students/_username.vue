<template>
  <b-container>
    <h4>Student Details:</h4>
    <p>Username: {{ student.username }}</p>
    <p>Name: {{ student.name }}</p>
    <p>Email: {{ student.email }}</p>
    <p>Course: {{ student.courseCode }}</p>
    <h4>Subjects enrolled:</h4>
    <b-table
      v-if="subjects.length"
      striped
      over
      :items="subjects"
      :fields="subjectFields"
    > <template v-slot:cell(unroll)="row">
          <input @click="unCheck($event, row.item.code)" type="checkbox" :value="row.item.code" />
        </template>
    </b-table>
     <p v-else>Student is not enrolled in any Subject</p>
      <button v-if="subjects.length" class="btn btn-info" @click.prevent="unrollStudentSubjects()">
        Unroll
      </button><br><br>
    <b-container class="form-group">
      <h4>Enroll in Course Subjects:</h4>
      <b-table
        v-if="allSubjectsEnroll.length"
        striped
        over
        :items="allSubjectsEnroll"
        :fields="subjectFieldsEnRoll"
      >
        <template v-slot:cell(enroll)="row">
          <input @click="check($event, row.item.code)" type="checkbox" :value="row.item.code" />
        </template>
      </b-table>
      <p v-else>Student enrolled in all the Course's subject</p>
      <button v-if="allSubjectsEnroll.length" class="btn btn-info" @click.prevent="enrollStudentSubjects()">
        Enroll
      </button>
      <br><br>
          <nuxt-link to="/students"
      ><img
        src="https://cdn-icons-png.flaticon.com/512/709/709624.png"
        alt="update"
        width="25"
        height="25"
    /></nuxt-link>
    </b-container>
  </b-container>
</template>
<script>
export default {
  methods:{
    check:function(evt, code){
      if(evt.target.checked && !this.subjectsEnroll.includes(code)){
          this.subjectsEnroll.push(code);
      }else if(!evt.target.checked  && this.subjectsEnroll.includes(code)){
         this.subjectsEnroll.splice(this.subjectsEnroll.indexOf(code),1);
      }
    },
    enrollStudentSubjects(){
       this.subjectsEnroll.forEach((code) => {
       this.$axios
          .$post(`/api/students/${this.username}/enroll/${code}`)
          .then(()=>{
            alert(`Student enrolled with success in subject: ${code}`)
            }
          )
       })
        this.$router.push(`/students/${this.username}`);
    },
    unCheck:function(evt, code){
      if(evt.target.checked && !this.subjectsUnroll.includes(code)){
          this.subjectsUnroll.push(code);
      }else if(!evt.target.checked  && this.subjectsUnroll.includes(code)){
         this.subjectsUnroll.splice(this.subjectsUnroll.indexOf(code),1);
      }
    },
    unrollStudentSubjects(){
       this.subjectsUnroll.forEach((code) => {
       this.$axios
          .$post(`/api/students/${this.username}/unroll/${code}`)
          .then(()=>{
            alert(`Student unrolled with success from subject: ${code}`)
            }
          )
       })
        this.$router.push(`/students/${this.username}`);
  }
  },
  data() {
    return {
      student: {},
      subjectFields: ["code", "name", "courseYear", "scholarYear","unroll"],
      allSubjectsEnroll: [],
      subjectFieldsEnRoll: [
        "code",
        "name",
        "courseYear",
        "scholarYear",
        "enroll",
      ],
      subjectsEnroll:[],
      subjectFieldsUnRoll: [
        "code",
        "name",
        "courseYear",
        "scholarYear",
        "unroll",
      ],
      subjectsUnroll:[]
    };
  },
  computed: {
    username() {
      return this.$route.params.username;
    },
    subjects() {
      return this.student.subjectDTOs || []
    }

  },
  created() {
    this.$axios
      .$get(`/api/students/${this.username}`)
      .then((student) => (this.student = student || {}))
      .then(() =>
        this.$axios
          .$get(`/api/courses/${this.student.courseCode}/subjects`)
          .then(
            (subjectsCourse) => (this.allSubjectsEnroll = subjectsCourse || {})
          )
          .then(() => {
            for (let i = 0; i < this.allSubjectsEnroll.length; i++) {
              this.subjects.forEach((sub) => {
                if (sub.code == this.allSubjectsEnroll[i].code) {
                  this.allSubjectsEnroll.splice(i, 1);
                  i = 0;
                  return;
                }
              });
            }
          })
      );
  },
};
</script>
