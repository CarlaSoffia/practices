<template>
  <div class="ml-4 mt-4">
    <h4>Send an E-mail to Student {{ student.name }} </h4>
    <form @submit.prevent="send" class="form-group w-50">
      <div>
        subject:
        <input v-model="subject" type="text" class="form-control" />
      </div>
      <div>
        message:
        <textarea v-model="message" name="message" class="form-control"></textarea>
      </div>

      <br>
       <div class="d-flex">
          <a :href="`/students/${username}`" class="btn btn-secondary mr-2">Student Details</a>
          <a :href="`/students`" class="btn btn-dark mr-2">Students</a>
          <button class="btn btn-info" @click.prevent="send">Send</button>
      </div>
    </form>
  </div>
</template>
<script>
export default {
  data() {
    return {
      student: {},
      subject: null,
      message: null,
    };
  },
  created() {
    this.$axios.$get(`/api/students/${this.username}`).then((student) => {
      this.student = student;
    });
  },
  computed: {
    username() {
      return this.$route.params.username;
    },
  },
  methods: {
    send() {
      this.$axios
        .$post(`/api/students/${this.username}/email/send`, {
          subject: this.subject,
          message: this.message,
        })
        .then((msg) => {
          this.$toast.success(msg).goAway(1500);
        })
        .catch((error) => {
          this.$toast.error("error sending the e-mail").goAway(3000);
        });
    },
  },
};
</script>
