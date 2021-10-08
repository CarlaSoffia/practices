package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.entities.Administrator;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Subject;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Teacher;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

@Stateless
public class TeacherBean {

    @PersistenceContext
    private EntityManager entityManager;

    public void create(String username, String password, String name, String email, String office){
        Teacher teacher = new Teacher(username, password, name, email, office);
        entityManager.persist(teacher);
    }

    public Teacher findTeacher(String username) {
        return entityManager.find(Teacher.class, username);
    }


    public boolean associateTeacherToSubject(String username, int subjectCode){
        Teacher teacher = entityManager.find(Teacher.class, username);
        if(teacher == null){
            return false;
        }
        Subject subject = entityManager.find(Subject.class, subjectCode);
        if(subject == null){
            return false;
        }

        subject.addTeacher(teacher);
        teacher.addSubject(subject);
        return true;
    }


    public boolean dissociateTeacherFromSubject(String username, int subjectCode){
        Teacher teacher = entityManager.find(Teacher.class, username);
        if(teacher == null){
            return false;
        }
        Subject subject = entityManager.find(Subject.class, subjectCode);
        if(subject == null){
            return false;
        }
        subject.removeTeacher(teacher);
        teacher.removeSubject(subject);
        return true;
    }
}
