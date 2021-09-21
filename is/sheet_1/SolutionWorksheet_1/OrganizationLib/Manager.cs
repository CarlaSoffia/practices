using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLib
{
    public class Manager : Employee
    {
        private List<Programmer> programmers;
        public int NumberOfProgrammers { get { return this.programmers.Count;  } }

        public Programmer this[int index]
        {
            get { return this.programmers[index]; }
        }
        public Manager(string firstName, string lastName, DateTime birthDate, double salary) : base(firstName, lastName, birthDate, salary)
        {
            this.programmers = new List<Programmer>();
        }

        public void AddProgrammer(Programmer newProgrammer)
        {
            programmers.Add(newProgrammer);
        }
        public override string Print()
        {
            string output = base.Print();
            output += "Numero de programadores: "  + NumberOfProgrammers + Environment.NewLine;
            output += "Programadores:" + Environment.NewLine;
            foreach (Programmer prog in this.programmers)
            {
                output += prog.FullName + Environment.NewLine;
            }
            return output;
        }
    }
}
