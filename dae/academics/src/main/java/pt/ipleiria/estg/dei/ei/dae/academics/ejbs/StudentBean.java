package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import java.util.List;

@Stateless
public class StudentBean {

    @PersistenceContext
    private EntityManager entityManager;

    public void create(String username, String password, String name, String email, int courseCode){
        Course course = entityManager.find(Course.class, courseCode);
        if(course == null) return;
        Student student = new Student(username, password, name, email, course);
        entityManager.persist(student);
        course.addStudent(student);
        entityManager.merge(course);
    }

    public List<Student> getAllStudents() {
        // remember, maps to: “SELECT s FROM Student s ORDER BY s.name”
        return (List<Student>) entityManager.createNamedQuery("getAllStudents").getResultList();
    }
    public Student findStudent(String username) {
        return entityManager.find(Student.class, username);
    }

}
