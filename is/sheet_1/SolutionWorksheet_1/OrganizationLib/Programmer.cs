using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLib
{
    public class Programmer : Employee
    {
        public Programmer(string firstName, string lastName, DateTime birthDate, double salary) 
            : base(firstName, lastName, birthDate, salary)
        {
        }
    }
}
