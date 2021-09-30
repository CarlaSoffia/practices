package pt.ipleiria.estg.dei.ei.dae.academics.entities;

import javax.persistence.*;
import java.util.LinkedList;
import java.util.List;

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
    @Id
    private int code;
    private String name;
    @OneToMany(mappedBy = "course", cascade = CascadeType.REMOVE)
    private List<Student> students;

    public Course() {
        this.students = new LinkedList<Student>();
    }

    public Course(int code, String name) {
        this.code = code;
        this.name = name;
        this.students = new LinkedList<Student>();
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
}
