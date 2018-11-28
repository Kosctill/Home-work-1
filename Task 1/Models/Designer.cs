using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class Designer : Employee
    {
        public float EfficiencyCoefficient { set; get; }

        public Designer ( string firstName, string lastName, decimal salary, 
                          byte experience, Manager manager, float efficiencyCoefficient ) :
                          base ( firstName, lastName, salary, experience, manager )
        {
            this.EfficiencyCoefficient = efficiencyCoefficient;
        }

        public override decimal GetSalary()
        {
            decimal finalSalary = this.Salary + (decimal)this.EfficiencyCoefficient;

            return GetSalaryWithBonus(finalSalary);
        }
    }
}
