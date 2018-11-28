using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public abstract class Employee
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public decimal Salary { set; get; }
        public byte Experience { set; get; }
        public Manager Manager { set; get; }

        public Employee ( string firstName, string lastName, decimal salary, byte experience, Manager manager )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Experience = experience;
            this.Manager = manager;
        }

        public virtual decimal GetSalary()
        {
            decimal finalSalary = this.Salary;

            return GetSalaryWithBonus(finalSalary);
        }

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

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}, manager: {this.Manager?.LastName ?? "Undefined"}, " +
                   $"experience: {this.Experience}";
        }
    }
}
