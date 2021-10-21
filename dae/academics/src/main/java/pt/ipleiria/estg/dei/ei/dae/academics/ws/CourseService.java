package pt.ipleiria.estg.dei.ei.dae.academics.ws;


import pt.ipleiria.estg.dei.ei.dae.academics.dtos.CourseDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.StudentDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.SubjectDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.ejbs.CourseBean;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Course;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Student;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Subject;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityExistsException;
import pt.ipleiria.estg.dei.ei.dae.academics.exceptions.MyEntityNotFoundException;

import javax.ejb.EJB;
import javax.ws.rs.*;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import java.util.List;
import java.util.stream.Collectors;

@Path("courses") // relative url web path for this service
@Produces({MediaType.APPLICATION_JSON}) // injects header “Content-Type: application/json”
@Consumes({MediaType.APPLICATION_JSON}) // injects header “Accept: application/json”

public class CourseService {
    @EJB
    private CourseBean courseBean;

    @GET // means: to call this endpoint, we need to use the HTTP GET method
    @Path("/") // means: the relative url path is "/api/courses/"
    public List<CourseDTO> getAllCoursesWS() {
        return toDTOs(courseBean.getAllCourses());
    }

    private CourseDTO toDTO(Course course){
        return new CourseDTO(
                course.getCode(),
                course.getName()
        );
    }
    private SubjectDTO toDTO(Subject subject){
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
    private List<CourseDTO> toDTOs(List<Course> courses) {
        return courses.stream().map(this::toDTO).collect(Collectors.toList());
    }
    private List<SubjectDTO> subjectsToDTOs(List<Subject> subjects) {
        return subjects.stream().map(this::toDTO).collect(Collectors.toList());
    }

    @POST // means: to call this endpoint, we need to use the HTTP POST method
    @Path("/")
    public Response createNewCourse (CourseDTO courseDTO) throws MyEntityExistsException, MyEntityNotFoundException {
        courseBean.create(courseDTO.getCode(),
                courseDTO.getName());
        Course newCourse = courseBean.findCourse(courseDTO.getCode());
        if(newCourse == null)
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR).build();
        return Response.status(Response.Status.CREATED)
                .entity(toDTO(newCourse))
                .build();
    }

    @PUT
    @Path("/{code}")
    public Response updateCourse(@PathParam("code") int code, CourseDTO courseDTO) throws MyEntityNotFoundException {

        Course course = courseBean.findCourse(code);
        if(course == null){
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        courseBean.update(course, courseDTO);
        return Response.status(Response.Status.ACCEPTED)
                .entity(toDTO(course))
                .build();
    }

    @DELETE
    @Path("/{code}")
    public Response deleteCourse(@PathParam("code") int code) throws MyEntityNotFoundException {
        Course course = courseBean.findCourse(code);
        if(course == null){
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        courseBean.remove(course);
        return Response.status(Response.Status.ACCEPTED)
                .entity(toDTO(course))
                .build();
    }


    @GET
    @Path("/{code}")
    public Response getCourse(@PathParam("code") int code) throws MyEntityNotFoundException {
        Course course = courseBean.findCourse(code);
        if(course == null){
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        return Response.status(Response.Status.ACCEPTED)
                .entity(toDTO(course))
                .build();
    }


    @GET
    @Path("/{code}/subjects")
    public Response getCourseSubjects(@PathParam("code") int code) throws MyEntityNotFoundException {
        Course course = courseBean.findCourse(code);
        if(course == null){
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        List<Subject> subjects = course.getSubjects();
        return Response.status(Response.Status.ACCEPTED)
                .entity(subjectsToDTOs(subjects))
                .build();
    }

}
