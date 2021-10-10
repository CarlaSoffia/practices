package pt.ipleiria.estg.dei.ei.dae.academics.ws;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.CourseDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.StudentDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.SubjectDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.ejbs.StudentBean;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Subject;

import javax.ejb.EJB;
import javax.ws.rs.*;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import java.util.List;
import java.util.stream.Collectors;

@Path("students") // relative url web path for this service
@Produces({MediaType.APPLICATION_JSON}) // injects header “Content-Type: application/json”
@Consumes({MediaType.APPLICATION_JSON}) // injects header “Accept: application/json”

public class StudentService {
    @EJB
    private StudentBean studentBean;

    @GET // means: to call this endpoint, we need to use the HTTP GET method
    @Path("/") // means: the relative url path is “/api/students/”
    public List<StudentDTO> getAllStudentsWS() {
        return toDTOs(studentBean.getAllStudents());
    }

    // Converts an entity Student to a DTO Student class
    private StudentDTO toDTO(Student student) {
        Course course = student.getCourse();
        return new StudentDTO(
                student.getEmail(),
                student.getName(),
                student.getUsername(),
                student.getPassword(),
                course.getCode(),
                course.getName()
        );
    }

    // converts an entire list of entities into a list of DTOs
    private List<StudentDTO> toDTOs(List<Student> students) {
        return students.stream().map(this::toDTO).collect(Collectors.toList());
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

    // converts an entire list of entities into a list of DTOs
    private List<SubjectDTO> subjectsToDTOs(List<Subject> subjects) {
        return subjects.stream().map(this::toDTO).collect(Collectors.toList());
    }

    @POST // means: to call this endpoint, we need to use the HTTP POST method
    @Path("/")
    public Response createNewStudent(StudentDTO studentDTO) {
        studentBean.create(studentDTO.getUsername(),
                studentDTO.getPassword(),
                studentDTO.getName(),
                studentDTO.getEmail(),
                studentDTO.getCourseCode());
        Student newStudent = studentBean.findStudent(studentDTO.getUsername());
        if (newStudent == null)
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR).build();
        return Response.status(Response.Status.CREATED)
                .entity(toDTO(newStudent))
                .build();
    }

    @GET
    @Path("/{username}")
    public Response getStudentDetails(@PathParam("username") String username) {
        Student student = studentBean.findStudent(username);
        if (student == null) {
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        return Response.status(Response.Status.OK)
                .entity(toDTO(student))
                .build();
    }

    @DELETE
    @Path("/{username}")
    public Response deleteCourse(@PathParam("username") String username) {
        Student student = studentBean.findStudent(username);
        if (student == null) {
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        studentBean.remove(student);
        return Response.status(Response.Status.OK)
                .entity(toDTO(student))
                .build();
    }

    @PUT
    @Path("/{username}")
    public Response updateStudent(@PathParam("username") String username, StudentDTO studentDTO) {

        Student student = studentBean.findStudent(username);
        if (student == null) {
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        studentBean.update(student, studentDTO);
        return Response.status(Response.Status.OK)
                .entity(toDTO(student))
                .build();
    }

    @GET
    @Path("/{username}/subjects")
    public Response getStudentSubjects(@PathParam("username") String username) {
        Student student = studentBean.findStudent(username);
        if (student != null) {
            return Response.ok(subjectsToDTOs(student.getSubjects())).build();
        }
        return Response.status(Response.Status.NOT_FOUND)
                .entity("ERROR_FINDING_STUDENT")
                .build();
    }


    @POST
    @Path("/{username}/unroll/{code}")
    public Response unrollStudentSubject(@PathParam("username") String username, @PathParam("code") int code) {
        boolean studentUnnrolled = studentBean.unrollStudentInSubject(username, code);

        if (!studentUnnrolled) {
            return Response.status(Response.Status.NOT_FOUND)
                    .entity("ERROR_UNROLLING_STUDENT")
                    .build();

        }
        Student student = studentBean.findStudent(username);
        return Response.ok(subjectsToDTOs(student.getSubjects())).build();
    }


    @POST
    @Path("/{username}/enroll/{code}")
    public Response enrollStudentSubject(@PathParam("username") String username, @PathParam("code") int code) {
        boolean studentEnrolled = studentBean.enrollStudentInSubject(username, code);

        if (!studentEnrolled) {
            return Response.status(Response.Status.NOT_FOUND)
                    .entity("ERROR_ENROLLING_STUDENT")
                    .build();

        }
        Student student = studentBean.findStudent(username);
        return Response.ok(subjectsToDTOs(student.getSubjects())).build();
    }
}