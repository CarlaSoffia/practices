package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;

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
        this.getAllCourses();
    }

    public List<Course> getAllCourses() {
        return (List<Course>) entityManager.createNamedQuery("getAllCourses").getResultList();
    }
}
