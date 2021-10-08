package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Subject;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import java.util.List;

@Stateless
public class SubjectBean {


    @PersistenceContext
    private EntityManager entityManager;

    public void create(int code, String name, Course course, int courseYear, int scholarYear){
        Course courseFound = entityManager.find(Course.class, course.getCode());
        if(courseFound == null) return;
        Subject subject = new Subject(code, name, courseFound,courseYear, scholarYear);
        entityManager.persist(subject);
    }
    public Subject findSubject(int code) {
        return entityManager.find(Subject.class, code);
    }

    public List<Subject> getAllSubjects(){
        return (List<Subject>) entityManager.createNamedQuery("getAllSubjects").getResultList();
    }

    public List<Student> getAllStudentsSubject(int code){
        Subject subjectFound = entityManager.find(Subject.class,code);
        if(subjectFound == null){
            return null;
        }
        return subjectFound.getStudents();
    }

}
