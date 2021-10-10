package pt.ipleiria.estg.dei.ei.dae.academics.entities;

import javax.persistence.*;
import javax.validation.constraints.NotNull;
import java.util.ArrayList;
import java.util.List;

@Entity

@NamedQueries({
        @NamedQuery(
                name = "getAllTeachers",
                query = "SELECT t FROM Teacher t ORDER BY t.name" // JPQL
        )
})

public class Teacher extends User{
    @NotNull
    private String office;
    @ManyToMany(mappedBy = "teachers")
    private List<Subject> subjects;

    public Teacher() {
        this.subjects = new ArrayList<>();
    }

    public Teacher(String username, String password, String name, String email, String office) {
        super(username, password, name, email);
        this.office = office;
        this.subjects = new ArrayList<>();
    }

    public String getOffice() {
        return office;
    }

    public void setOffice(String office) {
        this.office = office;
    }

    public List<Subject> getSubjects() {
        return subjects;
    }

    public void setSubjects(List<Subject> subjects) {
        this.subjects = subjects;
    }

    public void addSubject(Subject subject){
        if(subject == null || subjects.contains(subject)){
            return;
        }
        subjects.add(subject);
    }

    public void removeSubject(Subject subject){
        if(subject == null || !subjects.contains(subject)){
            return;
        }
        subjects.remove(subject);
    }
}
