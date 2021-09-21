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
        studentBean.create("123_ana", "qqk41-fm7Q", "Ana Gomes", "ana.gomes@gmai.com");
        System.out.println("-----------------   THE END   -----------------");
    }

}
