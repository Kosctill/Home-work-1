using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    /// <summary>
    /// It's abstract class for all types of employees (Developers, Designers, Managers)
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// First name of the employee
        /// </summary>
        public string FirstName { set; get; }

        /// <summary>
        /// Last name of the employee
        /// </summary>
        public string LastName { set; get; }

        /// <summary>
        /// Salary of the employee
        /// </summary>
        public decimal Salary { set; get; }

        /// <summary>
        /// Experience of the employee
        /// </summary>
        public byte Experience { set; get; }

        /// <summary>
        /// Appropriate Manager of the employee
        /// </summary>
        public Manager Manager { set; get; }

        /// <summary>
        /// Accepts a first name, last name, salary, experience
        /// and appropriate manager for initial initialiation 
        ///</summary>
        /// <param name="firstName">First name of the employee</param>
        /// <param name="lastName">Last name of the employee</param>
        /// <param name="salary">Salary of the employee</param>
        /// <param name="experience">Experience of the employee</param>
        /// <param name="manager">Appropriate manager of the employee</param>
        public Employee ( string firstName, string lastName, decimal salary, byte experience, Manager manager )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Experience = experience;
            this.Manager = manager;
        }

        /// <summary>
        /// Returns salary taking into account bonuses
        /// </summary>
        /// <returns>Salary with bonuses</returns>
        public virtual decimal GetSalary()
        {
            decimal finalSalary = this.Salary;

            return GetSalaryWithBonus(finalSalary);
        }

        /// <summary>
        /// Calculates bonuses to salary taking into
        /// account experience and adds them to salary
        /// </summary>
        /// <param name="finalSalary">Salary of employee</param>
        /// <returns>Salary along with bonuses</returns>
        protected decimal GetSalaryWithBonus(decimal finalSalary)
        {
            if ( this.Experience > 5 )
            {
                finalSalary = finalSalary * 1.2m + 500;
            }
            else if ( this.Experience > 2 )
            {
                finalSalary += 200;
            }

            return finalSalary;
        }

        /// <summary>
        /// Returns general information about employee,
        /// namely: first name, last name, manager and experience 
        /// </summary>
        /// <returns>General information about amployee</returns>
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}, manager: {this.Manager?.LastName ?? "Undefined"}, " +
                   $"experience: {this.Experience}";
        }
    }
}
