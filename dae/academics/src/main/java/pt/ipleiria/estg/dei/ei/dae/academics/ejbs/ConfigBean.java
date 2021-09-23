package pt.ipleiria.estg.dei.ei.dae.academics.ejbs;

import javax.annotation.PostConstruct;
import javax.ejb.EJB;
import javax.ejb.Singleton;
import javax.ejb.Startup;


@Singleton
@Startup
public class ConfigBean {

    @EJB
    private StudentBean studentBean;

    @PostConstruct
    public void populateDB() {
        studentBean.create("carlaSoffia", "Fp73-Uk70", "Carla Sofia", "2191170@my.ipleiria.pt");
        System.out.println("-----------------   THE END   -----------------");
    }

}
