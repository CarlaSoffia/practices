package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.StudentDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.SubjectDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Subject;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Teacher;

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
        subject.getCourse().removeSubject(subject);
        entityManager.merge(subject.getCourse());
        entityManager.remove(entityManager.merge(subject));
    }

    public boolean unrollStudentInSubject(String username, int subjectCode){
        Student student = entityManager.find(Student.class, username);
        if(student == null){
            return false;
        }
        Subject subject = findSubject(subjectCode);
        if(subject == null){
            return false;
        }
        if(student.getCourse().getCode() != subject.getCourse().getCode()){
            return false;
        }
        subject.removeStudent(student);
        student.removeSubject(subject);
        entityManager.merge(student);
        entityManager.merge(subject);
        return true;
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

                for (Student s:
                        subject.getStudents()) {
                    unrollStudentInSubject(s.getUsername(), subject.getCode());
                    subject = findSubject(subject.getCode());;
                }

                //Removes from the previous course
                subject.getCourse().removeSubject(subject);
                entityManager.merge(subject.getCourse());

                //Adds subject to new course
                subject.setCourse(course);
                course.addSubject(subject);
                entityManager.merge(course);
            }
        }
        entityManager.merge(subject);

    }

}
