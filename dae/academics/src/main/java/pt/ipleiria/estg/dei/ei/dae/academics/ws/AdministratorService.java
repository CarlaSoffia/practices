package pt.ipleiria.estg.dei.ei.dae.academics.ws;

import pt.ipleiria.estg.dei.ei.dae.academics.dtos.AdministratorDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.dtos.TeacherDTO;
import pt.ipleiria.estg.dei.ei.dae.academics.ejbs.AdministratorBean;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Administrator;
import pt.ipleiria.estg.dei.ei.dae.academics.entities.Teacher;

import javax.ejb.EJB;
import javax.ws.rs.*;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import java.util.List;
import java.util.stream.Collectors;

@Path("administrators") // relative url web path for this service
@Produces({MediaType.APPLICATION_JSON}) // injects header “Content-Type: application/json”
@Consumes({MediaType.APPLICATION_JSON}) // injects header “Accept: application/json”

public class AdministratorService {
    @EJB
    private AdministratorBean administratorBean;

    private AdministratorDTO toDTO(Administrator administrator) {
        return new AdministratorDTO(
                administrator.getUsername(),
                administrator.getPassword(),
                administrator.getName(),
                administrator.getEmail()
        );
    }
    private List<AdministratorDTO> toDTOs(List<Administrator> administrators) {
        return administrators.stream().map(this::toDTO).collect(Collectors.toList());
    }


    @POST
    @Path("/")
    public Response createAdministrator(AdministratorDTO administratorDTO){
        administratorBean.create(administratorDTO.getUsername(), administratorDTO.getPassword(), administratorDTO.getName(), administratorDTO.getEmail());
        Administrator administrator = administratorBean.findAdministrator(administratorDTO.getUsername());
        if(administrator == null){
            return Response.status(Response.Status.INTERNAL_SERVER_ERROR).build();
        }
        return Response.status(Response.Status.CREATED)
                .entity(toDTO(administrator))
                .build();
    }

    @PUT
    @Path("/{username}")
    public Response updateAdministrator(@PathParam("username") String username,AdministratorDTO administratorDTO){

        Administrator administrator = administratorBean.findAdministrator(username);
        if(administrator == null){
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        administratorBean.update(administrator, administratorDTO);
        return Response.status(Response.Status.ACCEPTED)
                .entity(toDTO(administrator))
                .build();
    }

    @GET
    @Path("/")
    public List<AdministratorDTO> getAllAdministratorsWS() {
        return toDTOs(administratorBean.getAllAdministrators());
    }

    @GET
    @Path("/{username}")
    public Response getAdministratorDetails(@PathParam("username") String username) {
        Administrator administrator = administratorBean.findAdministrator(username);
        if (administrator == null) {
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        return Response.status(Response.Status.OK)
                .entity(toDTO(administrator))
                .build();
    }


    @DELETE
    @Path("/{username}")
    public Response deleteAdministrator(@PathParam("username") String username) {
        Administrator administrator = administratorBean.findAdministrator(username);
        if (administrator == null) {
            return Response.status(Response.Status.NOT_FOUND).build();
        }
        administratorBean.remove(administrator);
        return Response.status(Response.Status.OK)
                .entity(toDTO(administrator))
                .build();
    }
}
