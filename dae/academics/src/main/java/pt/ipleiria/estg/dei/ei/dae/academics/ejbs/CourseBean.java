package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.CourseDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityExistsException;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityNotFoundException;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import java.util.List;

@Stateless
public class CourseBean {

    @PersistenceContext
    private EntityManager entityManager;

    public void create(int code, String name) throws MyEntityExistsException {
        Course course = entityManager.find(Course.class, code);
        if(course != null){
            throw  new MyEntityExistsException("There is a course with the code:"+code);
        }
        course = new Course(code, name);
        entityManager.persist(course);
    }
    public void remove(Course course){
        entityManager.remove(entityManager.merge(course));
    }
    public List<Course> getAllCourses() {
        return (List<Course>) entityManager.createNamedQuery("getAllCourses").getResultList();
    }

    public Course findCourse(int courseCode) throws MyEntityNotFoundException {
        Course course = entityManager.find(Course.class, courseCode);
        if(course == null){
            throw  new MyEntityNotFoundException("There is no course with the code:"+courseCode);
        }
        return course;
    }

    public void update(Course course, CourseDTO courseDTO) {
        if(courseDTO.getName() != null && !course.getName().equals(courseDTO.getName())){
            course.setName(courseDTO.getName());
            entityManager.merge(course);
        }
    }
}
