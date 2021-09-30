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

    @EJB
    private CourseBean courseBean;
    @PostConstruct
    public void populateDB() {
        courseBean.create(9991, "Computer Engineer");
        courseBean.create(1222, "Accounts and Finaces");
        courseBean.create(3332, "Pharmacology Science");
        studentBean.create("carlaSoffia", "Fp73-Uk70", "Carla Sofia", "2191170@my.ipleiria.pt", 9991);
        studentBean.create("anaMendes", "Sk43#Wk76", "Ana Mendes", "2181264@my.ipleiria.pt", 1222);
        System.out.println("-----------------   THE END   -----------------");
    }

}
