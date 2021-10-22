package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.SubjectDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.TeacherDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.*;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityExistsException;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityNotFoundException;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import java.util.List;

@Stateless
public class TeacherBean {

    @PersistenceContext
    private EntityManager entityManager;

    public void create(String username, String password, String name, String email, String office) throws MyEntityExistsException {
        Teacher teacher = entityManager.find(Teacher.class,username);
        if(teacher != null) throw new MyEntityExistsException("There is a teacher with the username: "+username);
        teacher = new Teacher(username, password, name, email, office);
        entityManager.persist(teacher);
    }

    public List<Teacher> getAllTeachers(){
        return (List<Teacher>) entityManager.createNamedQuery("getAllTeachers").getResultList();
    }
    public Teacher findTeacher(String username) throws MyEntityNotFoundException {

        Teacher teacher = entityManager.find(Teacher.class, username);
        if(teacher == null) throw new MyEntityNotFoundException("There is no teacher with the username: "+username);
        return teacher;
    }


    public boolean associateTeacherToSubject(String username, int subjectCode) throws MyEntityNotFoundException {
        Teacher teacher = findTeacher(username);
        Subject subject = entityManager.find(Subject.class, subjectCode);
        if(subject == null){
            throw new MyEntityNotFoundException("There is no subject with the code: "+subjectCode);
        }
        subject.addTeacher(teacher);
        teacher.addSubject(subject);
        entityManager.merge(teacher);
        entityManager.merge(subject);
        return true;
    }


    public boolean dissociateTeacherFromSubject(String username, int subjectCode) throws MyEntityNotFoundException {
        Teacher teacher = findTeacher(username);
        Subject subject = entityManager.find(Subject.class, subjectCode);
        if(subject == null){
            throw new MyEntityNotFoundException("There is no subject with the code: "+subjectCode);
        }
        subject.removeTeacher(teacher);
        teacher.removeSubject(subject);
        entityManager.merge(teacher);
        entityManager.merge(subject);
        return true;
    }

    public void update(Teacher teacher, TeacherDTO teacherDTO) {
        if(teacherDTO.getName() != null && !teacher.getName().equals(teacherDTO.getName())){
            teacher.setName(teacherDTO.getName());
        }
        if(teacherDTO.getPassword() != null && !teacher.getPassword().equals(teacherDTO.getPassword())){
            teacher.setPassword(teacherDTO.getPassword());
        }
        if(teacherDTO.getEmail() != null && !teacher.getEmail().equals(teacherDTO.getEmail())){
            teacher.setEmail(teacherDTO.getEmail());
        }
        if(teacherDTO.getOffice() != null && !teacher.getOffice().equals(teacherDTO.getOffice())){
            teacher.setOffice(teacherDTO.getOffice());
        }

        entityManager.merge(teacher);
    }


    public void remove(Teacher teacher) throws MyEntityNotFoundException {
        for (Subject s:
                teacher.getSubjects()) {
            dissociateTeacherFromSubject(teacher.getUsername(),s.getCode());
            teacher=entityManager.find(Teacher.class,teacher.getUsername());
        }
        entityManager.remove(entityManager.merge(teacher));
    }

}
