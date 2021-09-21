using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLib
{
    public abstract class Employee : Person
    {
        private double salary;
        public virtual double Salary { get { return salary; } }

        protected Employee(string firstName, string lastName, DateTime birthDate, double salary)
            : base(firstName, lastName, birthDate)
        {
            this.salary = salary;
        }
        
        public override string Print()
        {
            string output = base.Print() + "Salário: " + this.salary + " euros" + Environment.NewLine;
            return output;
        }


    }
}
