using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLib
{
    class ExPersonAlreadyExists : Exception
    {
        public ExPersonAlreadyExists(string message) : base(message)
        {
        }
    }
}
