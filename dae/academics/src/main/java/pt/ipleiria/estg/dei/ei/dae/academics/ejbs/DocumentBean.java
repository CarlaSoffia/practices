package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.entities.Document;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityExistsException;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityNotFoundException;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import java.util.List;

@Stateless
public class DocumentBean {

    @PersistenceContext
    private EntityManager entityManager;

    public void create(String username, String filepath, String filename) throws MyEntityNotFoundException {
        Student student = entityManager.find(Student.class, username);
        if(student == null){
            throw  new MyEntityNotFoundException("There is no student with the username:"+username);
        }
        Document document = new Document(filepath,filename,student);
        entityManager.persist(document);
    }
    public Document findDocument(int id) throws MyEntityNotFoundException {
        Document document = entityManager.find(Document.class, id);
        if(document == null){
            throw  new MyEntityNotFoundException("There is no document with the id:"+id);
        }
        return document;
    }
    public List<Document> getStudentDocuments(String username) throws MyEntityNotFoundException {
        Student student = entityManager.find(Student.class, username);
        if(student == null){
            throw  new MyEntityNotFoundException("There is no student with the username:"+username);
        }
        return student.getDocuments();
    }


}
