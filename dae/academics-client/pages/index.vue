<template>
 <!-- easy components usage, already shipped with bootstrap css-->
 <b-container>
 <!-- try to remove :fields=”fields” to see the magic -->
 <b-table striped over :items="students" :fields="fields" />
 </b-container>
</template>
<script>
export default {
 data () {
 return {
 fields: ['username', 'name', 'email'],
 students: []
 }
 },
 created () {
 this.$axios.$get('http://localhost:8080/academics/api/students/')
 .then((students) => {
 this.students = students
 })
 }
}
</script>
<style></style>
