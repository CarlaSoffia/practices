package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import java.util.List;

@Stateless
public class CourseBean {

    @PersistenceContext
    private EntityManager entityManager;

    public void create(int code, String name){
        Course course = new Course(code, name);
        entityManager.persist(course);
    }
    //TO-DO
    public void remove(Course course){
        List<Student> students = course.getStudents();
        for (Student student:students) {
            course.removeStudent(student);
            entityManager.remove(student);
        }
        entityManager.remove(course);
    }
    public List<Course> getAllCourses() {
        return (List<Course>) entityManager.createNamedQuery("getAllCourses").getResultList();
    }

    public Course findCourse(int courseCode) {
        return entityManager.find(Course.class, courseCode);
    }
}
