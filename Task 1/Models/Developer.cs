using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    /// <summary>
    /// This class is inherited from Employee class and represents type Developer
    /// </summary>
    public class Developer : Employee
    {
        /// <summary>
        /// This constructor makes initial initialization for Developer entity
        /// </summary>
        /// <param name="firstName">Fist name of the developer</param>
        /// <param name="lastName">Last name of the developer</param>
        /// <param name="salary">Salary of the developer</param>
        /// <param name="experience">Experience of the developer</param>
        /// <param name="manager">Appropriate manager of the developer</param>
        public Developer ( string firstName, string lastName, decimal salary, byte experience, Manager manager) :
                         base ( firstName, lastName, salary, experience, manager ) { }
    }
}
