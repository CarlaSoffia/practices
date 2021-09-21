using OrganizationLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSheet_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ficha 1");
       
            /*      VARIABLES       */
            Programmer programmer1 = new Programmer("Carla", "Mendes", new DateTime(2000, 09, 22), 1200);        
            Programmer programmer2 = new Programmer("Maria", "Gomes", new DateTime(2001, 01, 02), 800);
            Programmer programmer3 = new Programmer("Ana Bela", "Crus", new DateTime(1988, 02,09), 1400);
            Programmer programmer4 = new Programmer("Filipa", "Silva", new DateTime(1992, 03, 11), 900);
            Programmer programmer5 = new Programmer("Filipe", "Ferreira", new DateTime(1997, 05, 18), 1000);
            Programmer programmer6 = new Programmer("João", "Gaspar", new DateTime(1984, 06, 05), 800);
            Programmer programmer7 = new Programmer("Gonçalo", "Martins", new DateTime(1983, 01, 21), 1500);
            Programmer programmer8 = new Programmer("Rolando", "Gonçalves", new DateTime(2001, 08, 03), 1100);
            Programmer programmer9 = new Programmer("Lucas", "Pereira", new DateTime(2000, 10, 14), 1050);
            Programmer programmer10 = new Programmer("Clara", "Ferreira", new DateTime(1982, 12, 29), 950);

            Manager manager1 = new Manager("Margarida", "Dias", new DateTime(1973, 05, 04), 1500);
            Manager manager2 = new Manager("Dina", "Gomes", new DateTime(1978, 02, 02), 1200);

            Customer customer1 = new Customer("Carla", "Mendes", new DateTime(2000, 09, 22), "Rua das Maças");
            Customer customer2 = new Customer("Ana", "Mendes", new DateTime(1934, 01, 12), "Rua das Laranjeiras");
            Customer customer3 = new Customer("Ana Luísa", "Gonçalves", new DateTime(1995, 12, 2), "Rua da Nossa Senhora das Necessidades - Leiria");
            Customer customer4 = new Customer("Maria", "Silva", new DateTime(1973, 03, 29), "Rua Serrado das Pontes");
            Customer customer5 = new Customer("Graça", "Pereira", new DateTime(1944, 06, 22), "Rua da Alegria");
            Customer customer6 = new Customer("Adelino", "Simões", new DateTime(1974, 02, 24), "Rua de Lirão");
            Customer customer7 = new Customer("Catarina", "Martins", new DateTime(1934, 01, 12), "Rua do Coimbrão");
            Customer customer8 = new Customer("Marcos", "Crus", new DateTime(1995, 04, 2), "Rua da Nossa Senhora de Fátima - Leiria");
            Customer customer9 = new Customer("Duarte", "Silva", new DateTime(2003, 03, 29), "Rua Serrado");
            Customer customer10 = new Customer("Nicolas", "Gonçalves", new DateTime(1994, 07, 15), "Rua da Nossa Senhora");

            manager1.AddProgrammer(programmer1);
            manager1.AddProgrammer(programmer2);
            manager1.AddProgrammer(programmer3);
            manager1.AddProgrammer(programmer4);
            manager1.AddProgrammer(programmer5);

            manager2.AddProgrammer(programmer6);
            manager2.AddProgrammer(programmer7);
            manager2.AddProgrammer(programmer8);
            manager2.AddProgrammer(programmer9);
            manager2.AddProgrammer(programmer10);

            /*      LINQ & QUERIES      */
            List<Customer> customers = new List<Customer>();

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);
            customers.Add(customer5);

            IEnumerable<Customer> customersNames = customers
                .Where(customer => customer.FullName.StartsWith("A"))
                .Where(customer => customer.Address.Contains("Leiria"));
            
            foreach (Customer customer in customersNames)
            {
                Console.WriteLine(customer.Print());
            }

            int customersAge40 = customers
               .Where(customer => customer.Age > 40)
               .Count();

            Console.WriteLine("Number of costumers with age bigger than 40: " + customersAge40);

            /*      CREATE TYPES AND PERSONALIZE EXCEPTIONS     */


            Persons people = new Persons();
            people.AddPerson(manager1);
            people.AddPerson(manager2);

            people.AddPerson(customer1);
            people.AddPerson(customer2);
            people.AddPerson(customer3);
            people.AddPerson(customer4);
            people.AddPerson(customer5);
            people.AddPerson(customer6);
            people.AddPerson(customer7);
            people.AddPerson(customer8);
            people.AddPerson(customer9);
            people.AddPerson(customer10);

            people.AddPerson(programmer1);
            people.AddPerson(programmer2);
            people.AddPerson(programmer3);
            people.AddPerson(programmer4);
            people.AddPerson(programmer5);
            people.AddPerson(programmer6);
            people.AddPerson(programmer7);
            people.AddPerson(programmer8);
            people.AddPerson(programmer9);
            people.AddPerson(programmer10);

            Console.WriteLine("Total people: " + people.NumberOfPersons()+ Environment.NewLine + 
                "Total Managers: "  + people.NumberOfManagers() + Environment.NewLine + 
                "Total Programmers: " + people.NumberOfProgrammers() + Environment.NewLine);
            Console.ReadLine();
        }
    }
}
