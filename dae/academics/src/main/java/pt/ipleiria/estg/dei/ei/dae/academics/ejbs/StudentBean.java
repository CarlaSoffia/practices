package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.StudentDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Subject;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Teacher;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyConstraintViolationException;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityExistsException;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityNotFoundException;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.LockModeType;
import javax.persistence.PersistenceContext;
import javax.validation.ConstraintViolationException;
import java.util.ArrayList;
import java.util.List;

@Stateless
public class StudentBean {

    @PersistenceContext
    private EntityManager entityManager;

    public void create(String username, String password, String name, String email, int courseCode) throws MyEntityNotFoundException, MyEntityExistsException, MyConstraintViolationException {
        Course course = entityManager.find(Course.class, courseCode);
        if(course == null) throw  new MyEntityNotFoundException("There is no course with the code: "+courseCode);
        Student student = entityManager.find(Student.class, username);
        if(student != null) throw new MyEntityExistsException("There is a student with username: "+student.getUsername());
        try{
            student = new Student(username, password, name, email, course);
            entityManager.persist(student);
            course.addStudent(student);
            entityManager.merge(course);
        }catch (ConstraintViolationException e){
            throw new MyConstraintViolationException(e);
        }
    }

    public void remove(Student student) throws MyEntityNotFoundException {
        for (Subject s:
                student.getSubjects()) {
            unrollStudentInSubject(student.getUsername(),s.getCode());
            student=entityManager.find(Student.class,student.getUsername());
        }
        entityManager.remove(entityManager.merge(student));
    }

    public List<Student> getAllStudents() {
        return (List<Student>) entityManager.createNamedQuery("getAllStudents").getResultList();
    }
    public Student findStudent(String username) throws MyEntityNotFoundException {
        Student student = entityManager.find(Student.class, username);
        if (student == null){
            throw  new MyEntityNotFoundException("There is no student with the username: "+username);
        }
        return student;
    }

    public void update(Student student, StudentDTO studentDTO) throws MyEntityNotFoundException {
        entityManager.lock(entityManager.merge(student), LockModeType.OPTIMISTIC);
        if(studentDTO.getName() != null && !student.getName().equals(studentDTO.getName())){
            student.setName(studentDTO.getName());
        }
        if(studentDTO.getPassword() != null && !student.getPassword().equals(studentDTO.getPassword())){
            student.setPassword(studentDTO.getPassword());
        }
        if(studentDTO.getEmail() != null && !student.getEmail().equals(studentDTO.getEmail())){
            student.setEmail(studentDTO.getEmail());
        }
        if(studentDTO.getCourseCode() != 0 && student.getCourse().getCode() != studentDTO.getCourseCode()){
            Course course = entityManager.find(Course.class, studentDTO.getCourseCode());
            if(course != null){
                for (Subject s:
                        student.getSubjects()) {
                    unrollStudentInSubject(student.getUsername(), s.getCode());
                    student = entityManager.find(Student.class, student.getUsername());

                }

                student.getCourse().removeStudent(student);
                entityManager.merge(student.getCourse());

                //Adds student to new course
                student.setCourse(course);
                course.addStudent(student);
                entityManager.merge(course);
            }
            throw  new MyEntityNotFoundException("There is no course with the code: "+studentDTO.getCourseCode());
        }
        entityManager.merge(student);
    }


    public boolean enrollStudentInSubject(String username, int subjectCode) throws MyEntityNotFoundException {
        Student student = findStudent(username);
        Subject subject = entityManager.find(Subject.class, subjectCode);
        if (subject == null){
            throw  new MyEntityNotFoundException("There is no subject with the code: "+subjectCode);
        }
        if(student.getCourse().getCode() != subject.getCourse().getCode()){
            return false;
        }
        subject.addStudent(student);
        student.addSubject(subject);
        entityManager.merge(student);
        entityManager.merge(subject);
        return true;
    }


    public boolean unrollStudentInSubject(String username, int subjectCode) throws MyEntityNotFoundException {
        Student student = findStudent(username);
        Subject subject = entityManager.find(Subject.class, subjectCode);
        if (subject == null){
            throw  new MyEntityNotFoundException("There is no subject with the code: "+subjectCode);
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
}
