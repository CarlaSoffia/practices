package pt.ipleiria.estg.dei.ei.dae.academics.ws;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.CourseDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.StudentDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.ejbs.StudentBean;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;

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

    @POST // means: to call this endpoint, we need to use the HTTP POST method
    @Path("/")
    public Response createNewStudent (StudentDTO studentDTO){
        studentBean.create(studentDTO.getUsername(),
                studentDTO.getPassword(),
                studentDTO.getName(),
                studentDTO.getEmail(),
                studentDTO.getCourseCode());
        Student newStudent = studentBean.findStudent(studentDTO.getUsername());
        if(newStudent == null)
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR).build();
        return Response.status(Response.Status.CREATED)
                .entity(toDTO(newStudent))
                .build();
    }

    // converts an entire list of entities into a list of DTOs
    private List<StudentDTO> toDTOs(List<Student> students) {
        return students.stream().map(this::toDTO).collect(Collectors.toList());
    }

    @GET
    @Path("/{username}")
    public Response getStudent(@PathParam("username") String username)  {
        Student student = studentBean.findStudent(username);
        if(student == null){
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        return Response.status(Response.Status.FOUND)
                .entity(toDTO(student))
                .build();
    }

    @DELETE
    @Path("/{username}")
    public Response deleteCourse(@PathParam("username") String username) {
        Student student = studentBean.findStudent(username);
        if(student == null){
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        studentBean.remove(student);
        return Response.status(Response.Status.ACCEPTED)
                .entity(toDTO(student))
                .build();
    }

    @PUT
    @Path("/{username}")
    public Response updateCourse(@PathParam("username") String username, StudentDTO studentDTO){

        Student student = studentBean.findStudent(username);
        if(student == null){
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        studentBean.update(student, studentDTO);
        return Response.status(Response.Status.ACCEPTED)
                .entity(toDTO(student))
                .build();
    }
}
