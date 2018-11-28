using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class Developer : Employee
    {
        public Developer ( string firstName, string lastName, decimal salary, byte experience, Manager manager) :
                         base ( firstName, lastName, salary, experience, manager ) { }
    }
}
