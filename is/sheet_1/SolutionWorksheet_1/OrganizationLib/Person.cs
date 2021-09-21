using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLib
{
    public abstract class Person : IPrintable
    {
        private string firstName;
        private string lastName;
        //private DateTime birthDate;
        
        //Implement a property: write propfull and 2 tabs

        private DateTime birthDate;

      
        // to create the constructor set the cursor to Person and alt+tab
        protected Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.Gender = GenderType.Indefinido;
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

       
        public string FullName
        {
            get { return this.firstName + " " + this.lastName; }
        }
        
        public int Age
        {
            get {
                    int idade = DateTime.Today.Year - this.birthDate.Year;
                if (this.birthDate.Month > DateTime.Today.Month)
                {
                    idade--;                
                }
                if (this.birthDate.Month == DateTime.Today.Month && this.birthDate.Day > DateTime.Today.Day)
                {
                    idade--;
                }
                return idade;
                }
        }
        //auto implemented property prop 2 tabs
        public GenderType Gender { get; set; }

        //virtual - allows the reimplementation
        //override - to reimplement
        //Environment.NewLine use instead of \n
        virtual public string Print()
        {
            string output = "----------------" + Environment.NewLine;
            output += "Nome: " + FullName + Environment.NewLine;
            output += "Idade: " + Age + Environment.NewLine;
            output += "Genero: " + Gender + Environment.NewLine;
            output += "----------------" + Environment.NewLine;
            return output;
        }

        public string PrintToXML()
        {
            throw new NotImplementedException();
        }
    }
}
