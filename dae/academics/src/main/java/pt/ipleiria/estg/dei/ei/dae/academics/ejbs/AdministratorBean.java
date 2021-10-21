package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.AdministratorDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Administrator;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Teacher;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import java.util.List;

@Stateless
public class AdministratorBean {

    @PersistenceContext
    private EntityManager entityManager;

    public void create(String username, String password, String name, String email){
        Administrator admin = new Administrator(username, password, name, email);
        entityManager.persist(admin);
    }
    public List<Administrator> getAllAdministrators(){
        return (List<Administrator>) entityManager.createNamedQuery("getAllAdministrators").getResultList();
    }

    public Administrator findAdministrator(String username) {
        return entityManager.find(Administrator.class, username);
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
