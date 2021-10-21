package pt.ipleiria.estg.dei.ei.dae.academics.entities;


import com.sun.istack.NotNull;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity

@NamedQueries({
        @NamedQuery(
                name = "getAllSubjects",
                query = "SELECT s FROM Subject s ORDER BY s.course.name, s.scholarYear DESC, s.courseYear, s.name" // JPQL
        )
})

@Table(name="SUBJECTS",
        uniqueConstraints = @UniqueConstraint(columnNames = {"NAME", "COURSE_CODE", "SCHOLAR_YEAR"})
)
public class Subject {
    @Version private int version;
    @Id
    private int code;
    private String name;
    @ManyToOne
    @JoinColumn(name = "COURSE_CODE")
    @NotNull
    private Course course;
    @Column(name="COURSE_YEAR")
    private int courseYear;
    @Column(name="SCHOLAR_YEAR")
    private int scholarYear;

    @ManyToMany
    @JoinTable(name = "SUBJECTS_STUDENTS",
            joinColumns = @JoinColumn(name = "SUBJECT_CODE", referencedColumnName = "CODE"),
            inverseJoinColumns = @JoinColumn(name = "STUDENT_USERNAME", referencedColumnName =
                    "USERNAME"))
    private List<Student> students;

    @ManyToMany
    @JoinTable(name = "SUBJECTS_TEACHERS",
            joinColumns = @JoinColumn(name = "SUBJECT_CODE", referencedColumnName = "CODE"),
            inverseJoinColumns = @JoinColumn(name = "TEACHER_USERNAME", referencedColumnName =
                    "USERNAME"))
    private List<Teacher> teachers;

    public Subject() {
        this.students = new ArrayList<>();
        this.teachers = new ArrayList<>();
    }

    public Subject(int code, String name, Course course, int courseYear, int scholarYear) {
        this.code = code;
        this.name = name;
        this.course = course;
        this.courseYear = courseYear;
        this.scholarYear = scholarYear;
        this.students = new ArrayList<>();
        this.teachers = new ArrayList<>();
    }

    public List<Teacher> getTeachers() {
        return teachers;
    }

    public void setTeachers(List<Teacher> teachers) {
        this.teachers = teachers;
    }
    public void addTeacher(Teacher teacher){
        if(teacher == null || teachers.contains(teacher)){
            return;
        }
        teachers.add(teacher);
    }

    public void removeTeacher(Teacher teacher){
        if(teacher == null || !teachers.contains(teacher)){
            return;
        }
        teachers.remove(teacher);
    }

    public void setCode(int code) {
        this.code = code;
    }

    public int getCode() {
        return code;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Course getCourse() {
        return course;
    }

    public void setCourse(Course course) {
        this.course = course;
    }

    public int getCourseYear() {
        return courseYear;
    }

    public void setCourseYear(int courseYear) {
        this.courseYear = courseYear;
    }

    public int getScholarYear() {
        return scholarYear;
    }

    public void setScholarYear(int scholarYear) {
        this.scholarYear = scholarYear;
    }

    public List<Student> getStudents() {
        return students;
    }

    public void setStudents(List<Student> students) {
        this.students = students;
    }

    public void addStudent(Student student){
        if(student == null || students.contains(student)){
            return;
        }
        students.add(student);
    }

    public void removeStudent(Student student){
        if(student == null || !students.contains(student)){
            return;
        }
        students.remove(student);
    }
}
