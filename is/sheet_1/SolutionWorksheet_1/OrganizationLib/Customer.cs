using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLib
{
    public class Customer : Person
    {
        public Customer(string firstName, string lastName, DateTime birthDate, string addr) 
            : base(firstName, lastName, birthDate)
        {
            Address = addr;
        }
        //auto implemented property prop 2 tabs
        public string Address { get; set; }


        public override string Print()
        {
            string output = base.Print();
            output += "Morada: " + Address + Environment.NewLine;
            return output;
        }

    }
}
