package pt.ipleiria.estg.dei.ei.dae.academics.entities;

import com.sun.istack.NotNull;

import javax.persistence.*;
import javax.validation.constraints.Email;
import java.util.LinkedList;
import java.util.List;

@Entity

@NamedQueries({
        @NamedQuery(
                name = "getAllStudents",
                query = "SELECT s FROM Student s ORDER BY s.name" // JPQL
        )
})


public class Student extends User{

    @ManyToOne
    @JoinColumn(name = "COURSE_CODE")
    @NotNull
    private Course course;
    @ManyToMany(mappedBy = "students")
    private List<Subject> subjects;

    public Student() {
        this.subjects = new LinkedList<Subject>();
    }

    public Student(String username, String password, String name, String email, Course course) {
        super(username,password,name, email);
        this.course = course;
        this.subjects = new LinkedList<Subject>();
    }

    public Course getCourse() {
        return course;
    }

    public void setCourse(Course course) {
        this.course = course;
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
}
