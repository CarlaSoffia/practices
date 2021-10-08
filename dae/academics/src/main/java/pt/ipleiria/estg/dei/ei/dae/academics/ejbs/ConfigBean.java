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

    @EJB
    private SubjectBean subjectBean;

    @EJB
    private AdministratorBean administratorBean;

    @EJB
    private TeacherBean teacherBean;

    @PostConstruct
    public void populateDB() {
        System.out.println("-----------------   BEGIN   -----------------");
        courseBean.create(9991, "Computer Engineer");
        courseBean.create(1222, "Accounts and Finaces");
        courseBean.create(3332, "Pharmacology Science");
        studentBean.create("carlaSoffia", "Fp73-Uk70", "Carla Sofia", "2191170@my.ipleiria.pt", 9991);
        studentBean.create("mary", "vfbt64", "Mary Poppins", "mary.poppins@outlook.en", 9991);
        studentBean.create("claire", "dfF234", "Claire Fraser", "claire@outlook.en", 9991);

        studentBean.create("anaMendes", "Sk43#Wk76", "Ana Mendes", "2181264@my.ipleiria.pt", 1222);
        subjectBean.create(1, "DAE", courseBean.findCourse(9991),3, 2021);
        subjectBean.create(2, "SBD", courseBean.findCourse(9991),2, 2021);
        subjectBean.create(3, "CFI", courseBean.findCourse(1222),1, 2019);
        subjectBean.create(4, "DEII", courseBean.findCourse(1222),3, 2019);
        subjectBean.create(5, "RC", courseBean.findCourse(9991),2, 2018);

        studentBean.enrollStudentInSubject("carlaSoffia", 1);
        studentBean.enrollStudentInSubject("carlaSoffia", 2);
        studentBean.enrollStudentInSubject("claire", 1);
        studentBean.enrollStudentInSubject("claire", 2);
        studentBean.enrollStudentInSubject("mary", 1);
        studentBean.enrollStudentInSubject("mary", 2);
        studentBean.enrollStudentInSubject("anaMendes", 3);
        studentBean.enrollStudentInSubject("anaMendes", 4);

        administratorBean.create("adminMaria", "123_qwe", "Maria Silva", "maria.silva@gmail.com");
        administratorBean.create("adminFabio", "wd6_0fg", "Fabio Gomes", "fabio.gomes@gmail.com");

        teacherBean.create("teacherJoao", "sjfg938_3h#", "João Martins", "joao_martins@gmail.com", "A.G.1.3");
        teacherBean.create("teacherBruna", "sjf$fjff3434_", "Bruna Fonseca", "bruna_fonseca@gmail.com", "A.G.0.1");

        System.out.println("-----------------   THE END   -----------------");
    }

}
