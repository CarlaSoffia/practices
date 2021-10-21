package pt.ipleiria.estg.dei.ei.dae.academics.ws;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.StudentDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.SubjectDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.TeacherDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.ejbs.SubjectBean;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Subject;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Teacher;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityNotFoundException;

import javax.ejb.EJB;
import javax.ws.rs.*;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import java.util.List;
import java.util.stream.Collectors;

@Path("subjects") // relative url web path for this service
@Produces({MediaType.APPLICATION_JSON}) // injects header “Content-Type: application/json”
@Consumes({MediaType.APPLICATION_JSON}) // injects header “Accept: application/json”

public class SubjectService {

    @EJB
    private SubjectBean subjectBean;


    // converts an entire list of entities into a list of DTOs
    private List<StudentDTO> studentsToDTOs(List<Student> students) {
        return students.stream().map(this::toDTO).collect(Collectors.toList());
    }

    private List<SubjectDTO> toDTOs(List<Subject> subjects) {
        return subjects.stream().map(this::toDTO).collect(Collectors.toList());
    }

    private StudentDTO toDTO(Student student) {
        Course course =student.getCourse();
        return new StudentDTO(
                student.getEmail(),
                student.getName(),
                student.getUsername(),
                student.getPassword(),
                course.getCode(),
                course.getName()
        );
    }
    private SubjectDTO toDTO(Subject subject) {
        Course course = subject.getCourse();
        return new SubjectDTO(
                subject.getCode(),
                subject.getName(),
                course.getCode(),
                course.getName(),
                subject.getCourseYear(),
                subject.getScholarYear()
        );
    }
    private TeacherDTO toDTO(Teacher teacher) {
        return new TeacherDTO(
                teacher.getUsername(),
                teacher.getPassword(),
                teacher.getName(),
                teacher.getEmail(),
                teacher.getOffice()
        );
    }
    private List<TeacherDTO> teacherToDTOs(List<Teacher> teachers) {
        return teachers.stream().map(this::toDTO).collect(Collectors.toList());
    }

    @GET
    @Path("/{code}/students")
    public Response getStudentsSubject(@PathParam("code") int code) {
        Subject subject = subjectBean.findSubject(code);
        if (subject != null) {
            return Response.ok(this.studentsToDTOs(subject.getStudents())).build();
        }
        return Response.status(Response.Status.NOT_FOUND)
                .entity("ERROR_FINDING_STUDENT")
                .build();
    }

    @GET
    @Path("/{code}/teachers")
    public Response getTeachersSubject(@PathParam("code") int code) {
        Subject subject = subjectBean.findSubject(code);
        if (subject != null) {
            return Response.ok(teacherToDTOs(subject.getTeachers())).build();
        }
        return Response.status(Response.Status.NOT_FOUND)
                .entity("ERROR_FINDING_SUBJECT")
                .build();
    }

    @POST
    @Path("/")
    public Response createSubject(SubjectDTO subjectDTO){
        subjectBean.create(subjectDTO.getCode(), subjectDTO.getName(), subjectDTO.getCourseCode(), subjectDTO.getCourseYear(), subjectDTO.getScholarYear());
        Subject subject = subjectBean.findSubject(subjectDTO.getCode());
        if(subject == null){
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR).build();
        }
        return Response.status(Response.Status.CREATED)
                .entity(toDTO(subject))
                .build();
    }

    @PUT
    @Path("/{code}")
    public Response updateSubject(@PathParam("code") int code, SubjectDTO subjectDTO) {

    Subject subject  = subjectBean.findSubject(code);

        if(subject == null){
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        subjectBean.update(subject, subjectDTO);
        return Response.status(Response.Status.ACCEPTED)
                .entity(toDTO(subject))
                .build();
    }

    @GET
    @Path("/")
    public List<SubjectDTO> getAllSubjectsWS() {
        return toDTOs(subjectBean.getAllSubjects());
    }

    @GET
    @Path("/{code}")
    public Response getSubjectDetails(@PathParam("code") int code){
       Subject subject = subjectBean.findSubject(code);
        if (subject == null) {
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        return Response.status(Response.Status.OK)
                .entity(toDTO(subject))
                .build();
    }


    @DELETE
    @Path("/{code}")
    public Response deleteSubject(@PathParam("code") int code){
        Subject subject = subjectBean.findSubject(code);
        if (subject == null) {
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        subjectBean.remove(subject);
        return Response.status(Response.Status.OK)
                .entity(toDTO(subject))
                .build();
    }
}


