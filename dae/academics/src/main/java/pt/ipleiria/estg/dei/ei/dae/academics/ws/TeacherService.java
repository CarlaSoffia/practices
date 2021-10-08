package pt.ipleiria.estg.dei.ei.dae.academics.ws;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.StudentDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.SubjectDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.ejbs.TeacherBean;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Subject;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Teacher;

import javax.ejb.EJB;
import javax.ws.rs.*;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import java.util.List;
import java.util.stream.Collectors;

@Path("teachers") // relative url web path for this service
@Produces({MediaType.APPLICATION_JSON}) // injects header “Content-Type: application/json”
@Consumes({MediaType.APPLICATION_JSON}) // injects header “Accept: application/json”

public class TeacherService {

    @EJB
    private TeacherBean teacherBean;

    // converts an entire list of entities into a list of DTOs
    private List<SubjectDTO> subjectsToDTOs(List<Subject> subjects) {
        return subjects.stream().map(this::toDTO).collect(Collectors.toList());
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

    @POST
    @Path("/{username}/associate/{code}")
    public Response associateTeacherSubject(@PathParam("username")  String username, @PathParam("code") int code) {

        boolean teacherAssociated = teacherBean.associateTeacherToSubject(username, code);

        if (!teacherAssociated) {
            return Response.status(Response.Status.NOT_FOUND)
                    .entity("ERROR_ASSOCIATING_TEACHER_SUBJECT")
                    .build();

        }
        Teacher teacher = teacherBean.findTeacher(username);
        return Response.ok(subjectsToDTOs(teacher.getSubjects())).build();
    }

    @POST
    @Path("/{username}/dissociate/{code}")
    public Response dissociateTeacherSubject(@PathParam("username")  String username, @PathParam("code") int code) {

        boolean teacherDissociated = teacherBean.dissociateTeacherFromSubject(username, code);

        if (!teacherDissociated) {
            return Response.status(Response.Status.NOT_FOUND)
                    .entity("ERROR_DISSOCIATING_TEACHER_SUBJECT")
                    .build();

        }
        Teacher teacher = teacherBean.findTeacher(username);
        return Response.ok(subjectsToDTOs(teacher.getSubjects())).build();
    }

    @GET
    @Path("/{username}/subjects")
    public Response getTeacherSubjects(@PathParam("username")  String username){
        Teacher teacher = teacherBean.findTeacher(username);
        if (teacher != null) {
            return Response.ok(subjectsToDTOs(teacher.getSubjects())).build();
        }
        return Response.status(Response.Status.NOT_FOUND)
                .entity("ERROR_FINDING_TEACHER")
                .build();
    }
}
