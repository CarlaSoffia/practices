package pt.ipleiria.estg.dei.ei.dae.academics.entities;

import javax.persistence.*;
import java.util.LinkedList;
import java.util.List;
import java.util.Objects;

@Entity

@NamedQueries({
        @NamedQuery(
                name = "getAllCourses",
                query = "SELECT c FROM Course c ORDER BY c.name" // JPQL
        )
})

@Table(
        name = "COURSES",
        uniqueConstraints = @UniqueConstraint(columnNames = {"NAME"})
)

public class Course {
    @Version private int version;
    @Id
    private int code;
    private String name;
    @OneToMany(mappedBy = "course", cascade = CascadeType.REMOVE)
    private List<Student> students;
    @OneToMany(mappedBy = "course", cascade = CascadeType.REMOVE)
    private List<Subject> subjects;

    public Course() {
        this.students = new LinkedList<Student>();
        this.subjects = new LinkedList<Subject>();
    }

    public Course(int code, String name) {
        this.code = code;
        this.name = name;
        this.students = new LinkedList<Student>();
        this.subjects = new LinkedList<Subject>();

    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getCode() {
        return code;
    }

    public void setCode(int code) {
        this.code = code;
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

    public List<Subject> getSubjects() {
        return subjects;
    }

    public void setSubjects(List<Subject> subjects) {
        this.subjects = subjects;
    }
    public void addSubject(Subject subject){
        if(subject == null || subjects.contains(subject)){
            return;
        }
        subjects.add(subject);
    }

    public void removeSubject(Subject subject){
        if(subject == null || !subjects.contains(subject)){
            return;
        }
        subjects.remove(subject);
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof Course)) return false;
        Course course = (Course) o;
        return code == course.code;
    }

    @Override
    public int hashCode() {
        return Objects.hash(code);
    }
}
