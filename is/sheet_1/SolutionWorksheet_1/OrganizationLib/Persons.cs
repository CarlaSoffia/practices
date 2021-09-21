using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLib
{
     public class Persons : Collection<Person>
    {
        public Person this[int index]
        {
            get { return this[index]; }
            set { this[index] = value; }
        }

        public void AddPerson(Person person)
        {
            if (this.Contains(person))
            {
                throw new ExPersonAlreadyExists("This person already exists in this collection");
            }

            this.Add(person);
        }

        public void RemovePerson(Person person)
        {
            if (!this.Contains(person))
            {
                throw new ExPersonDoNotExists("This person doesn't exists in this collection");
            }

            this.Remove(person);
        }

        public int NumberOfProgrammers()
        {
            Programmer p1 = new Programmer("Ana", "Mendes", new DateTime(2000, 09, 22), 1500);
            Type typeProg = p1.GetType();
            int numberProgrammers = 0;

            foreach (Person p in this)
            {
                if (p.GetType() == typeProg)
                {
                    numberProgrammers++;
                }
            }
            return numberProgrammers;
        }
        public int NumberOfManagers()
        {
            Manager m1 = new Manager("Carla","Mendes",new DateTime(2000, 09, 22), 1000);
            Type typeMan = m1.GetType();
            int numberManagers = 0;

            foreach (Person p in this)
            {
                if (p.GetType() == typeMan)
                {
                    numberManagers++;
                }
            }
            return numberManagers;
        }

        public int NumberOfPersons()
        {
            return this.Count();
        }


    }
}
