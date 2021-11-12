package pt.ipleiria.estg.dei.ei.dae.academics.entities;

import com.sun.istack.NotNull;

import javax.persistence.*;

@Entity
@NamedQuery(
        name = "getStudentDocuments",
        query = "SELECT doc FROM Document doc WHERE doc.student.username = :username")

@Table(name = "DOCUMENTS")
public class Document {
    private String filepath;
    private String filename;
    @ManyToOne
    @JoinColumn(name = "student_username")
    @NotNull
    private Student student;
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private long id;

    public Document() {
    }

    public Document(String filepath, String filename, Student student) {
        this.filepath = filepath;
        this.filename = filename;
        this.student = student;
    }

    public String getFilepath() {
        return filepath;
    }

    public void setFilepath(String filepath) {
        this.filepath = filepath;
    }

    public String getFilename() {
        return filename;
    }

    public void setFilename(String filename) {
        this.filename = filename;
    }

    public Student getStudent() {
        return student;
    }

    public void setStudent(Student student) {
        this.student = student;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }
}
