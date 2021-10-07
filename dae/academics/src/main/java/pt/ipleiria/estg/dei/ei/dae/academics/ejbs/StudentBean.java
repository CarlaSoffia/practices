package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.StudentDTO;
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

    public void remove(Student student){
        Student studentMerged = entityManager.merge(student);
        entityManager.remove(studentMerged);
    }

    public List<Student> getAllStudents() {
        // remember, maps to: “SELECT s FROM Student s ORDER BY s.name”
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
                //Removes from the previous course
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
}
