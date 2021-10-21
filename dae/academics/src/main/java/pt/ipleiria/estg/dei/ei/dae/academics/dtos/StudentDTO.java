package pt.ipleiria.estg.dei.ei.dae.academics.dtos;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class StudentDTO implements Serializable {
    private String username;
    private String password;
    private String name;
    private String email;
    private int courseCode;
    private String courseName;
    private List<SubjectDTO> subjectDTOs;
    public StudentDTO() {
    }

    public StudentDTO(String email,String name, String username, String password, int courseCode, String courseName) {
        this.username = username;
        this.password = password;
        this.name = name;
        this.email = email;
        this.courseCode = courseCode;
        this.courseName = courseName;
        this.subjectDTOs = new ArrayList<>();
    }

    public StudentDTO(String username, String password, String name, String email, int courseCode, String courseName, List<SubjectDTO> subjectDTOs) {
        this(username,password,name,email,courseCode,courseName);
        this.subjectDTOs = subjectDTOs;
    }

    public List<SubjectDTO> getSubjectDTOs() {
        return subjectDTOs;
    }

    public void setSubjectDTOs(List<SubjectDTO> subjectDTOs) {
        this.subjectDTOs = subjectDTOs;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public int getCourseCode() {
        return courseCode;
    }

    public void setCourseCode(int courseCode) {
        this.courseCode = courseCode;
    }

    public String getCourseName() {
        return courseName;
    }

    public void setCourseName(String courseName) {
        this.courseName = courseName;
    }
}
