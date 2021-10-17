package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.StudentDTO;
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

    public void remove(Student student){
        for (Subject s:
                student.getSubjects()) {
            unrollStudentInSubject(student.getUsername(),s.getCode());
            student=entityManager.find(Student.class,student.getUsername());
        }
        Student studentMerged = entityManager.merge(student);
        entityManager.remove(studentMerged);
    }

    public List<Student> getAllStudents() {
        return (List<Student>) entityManager.createNamedQuery("getAllStudents").getResultList();
    }
    public Student findStudent(String username) {
        return entityManager.find(Student.class, username);
    }

    public void update(Student student, StudentDTO studentDTO) {

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
        }
        entityManager.merge(student);
    }


    public boolean enrollStudentInSubject(String username, int subjectCode){
        Student student = entityManager.find(Student.class, username);
        if(student == null){
            return false;
        }
        Subject subject = entityManager.find(Subject.class, subjectCode);
        if(subject == null){
            return false;
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


    public boolean unrollStudentInSubject(String username, int subjectCode){
        Student student = entityManager.find(Student.class, username);
        if(student == null){
            return false;
        }
        Subject subject = entityManager.find(Subject.class, subjectCode);
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
}
