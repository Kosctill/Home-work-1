using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    /// <summary>
    /// It's class is inherited of Employee class and represents Designer entity
    /// </summary>
    public class Designer : Employee
    {
        /// <summary>
        /// Efficiency coefficient of the designer
        /// </summary>
        public float EfficiencyCoefficient { set; get; }

        /// <summary>
        /// It's constructor makes initial initialization of the Designer entity
        /// </summary>
        /// <param name="firstName">First name of the designer</param>
        /// <param name="lastName">Last name of the designer</param>
        /// <param name="salary">Salary of the designer</param>
        /// <param name="experience">Experience of the designer</param>
        /// <param name="manager">Appropriate manager of the designer</param>
        /// <param name="efficiencyCoefficient">Efficiency coefficient of the designer</param>
        public Designer ( string firstName, string lastName, decimal salary, 
                          byte experience, Manager manager, float efficiencyCoefficient ) :
                          base ( firstName, lastName, salary, experience, manager )
        {
            this.EfficiencyCoefficient = efficiencyCoefficient;
        }

        /// <summary>
        /// Calculates salary depending of efficiency coefficient
        /// </summary>
        /// <returns>Total salary with bonuses</returns>
        public override decimal GetSalary()
        {
            decimal finalSalary = this.Salary + (decimal)this.EfficiencyCoefficient;

            return GetSalaryWithBonus(finalSalary);
        }
    }
}
