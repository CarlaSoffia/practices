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

            int numberProgrammers = 0;

            foreach (Person p in this)
            {
                if (p.GetType() == typeof(Programmer))
                {
                    numberProgrammers++;
                }
            }
            return numberProgrammers;
        }
        public int NumberOfManagers()
        {
            int numberManagers = 0;

            foreach (Person p in this)
            {
                if (p.GetType() == typeof(Manager))
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
