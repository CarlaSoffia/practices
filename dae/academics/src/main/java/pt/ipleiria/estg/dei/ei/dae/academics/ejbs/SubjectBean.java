package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.StudentDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.SubjectDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Subject;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import java.util.ArrayList;
import java.util.List;

@Stateless
public class SubjectBean {


    @PersistenceContext
    private EntityManager entityManager;

    public void create(int code, String name, int courseCode, int courseYear, int scholarYear){
        Course course= entityManager.find(Course.class, courseCode);
        if(course == null) return;
        Subject subject = new Subject(code, name, course,courseYear, scholarYear);
        course.addSubject(subject);
        entityManager.persist(subject);
        entityManager.merge(course);
    }
    public Subject findSubject(int code) {
        return entityManager.find(Subject.class, code);
    }

    public List<Subject> getAllSubjects(){
        return (List<Subject>) entityManager.createNamedQuery("getAllSubjects").getResultList();
    }

    public void remove(Subject subject){
        Subject subjectMerged = entityManager.merge(subject);
        entityManager.remove(subjectMerged);
    }

    public void update(Subject subject, SubjectDTO subjectDTO) {
        if(subjectDTO.getName() != null && !subject.getName().equals(subjectDTO.getName())){
            subject.setName(subjectDTO.getName());
        }
        if(subjectDTO.getCourseYear() != 0 && subject.getCourseYear() != subjectDTO.getCourseYear()){
            subject.setCourseYear(subjectDTO.getCourseYear());
        }
        if(subjectDTO.getScholarYear() != 0 && subject.getScholarYear() != subjectDTO.getScholarYear()){
            subject.setScholarYear(subjectDTO.getScholarYear());
        }
        if( subjectDTO.getCourseCode()!= 0 && subject.getCourse().getCode() != subjectDTO.getCourseCode()){
            Course course = entityManager.find(Course.class, subjectDTO.getCourseCode());
            if(course != null){
                //Removes from the previous course
                subject.getCourse().removeSubject(subject);
                entityManager.merge(subject.getCourse());

                //Adds student to new course
                subject.setCourse(course);
                course.addSubject(subject);
                entityManager.merge(course);
            }
        }
        entityManager.merge(subject);
    }

}
