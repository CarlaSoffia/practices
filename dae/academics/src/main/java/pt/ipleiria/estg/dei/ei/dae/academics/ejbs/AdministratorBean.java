package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.AdministratorDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Administrator;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Teacher;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityExistsException;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityNotFoundException;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import java.util.List;

@Stateless
public class AdministratorBean {

    @PersistenceContext
    private EntityManager entityManager;

    public void create(String username, String password, String name, String email) throws MyEntityExistsException {
        Administrator admin = entityManager.find(Administrator.class, username);
        if(admin != null) throw new MyEntityExistsException("There is a administrator with the username: "+username);
        admin = new Administrator(username, password, name, email);
        entityManager.persist(admin);
    }
    public List<Administrator> getAllAdministrators(){
        return (List<Administrator>) entityManager.createNamedQuery("getAllAdministrators").getResultList();
    }

    public Administrator findAdministrator(String username) throws MyEntityNotFoundException {
        Administrator admin = entityManager.find(Administrator.class, username);
        if(admin == null) throw new MyEntityNotFoundException("There is no administrator with the username: "+username);
        return admin;
    }

    public void update(Administrator administrator, AdministratorDTO administratorDTO) {
        if(administratorDTO.getName() != null && !administrator.getName().equals(administratorDTO.getName())){
            administrator.setName(administratorDTO.getName());
        }
        if(administratorDTO.getPassword() != null && !administrator.getPassword().equals(administratorDTO.getPassword())){
            administrator.setPassword(administratorDTO.getPassword());
        }
        if(administratorDTO.getEmail() != null && !administrator.getEmail().equals(administratorDTO.getEmail())){
            administrator.setEmail(administratorDTO.getEmail());
        }
        entityManager.merge(administrator);
    }

    public void remove(Administrator administrator) {
        entityManager.remove(entityManager.merge(administrator));
    }
}
