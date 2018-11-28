using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    public class Manager : Employee
    {
        public List<Employee> Team { set; get; }

        public Manager ( string firstName, string lastName, decimal salary,
                         byte experience, Manager manager, List<Employee> team ) :
                         base ( firstName, lastName, salary, experience, manager )
        {
            this.Team = team;
        }

        public override decimal GetSalary()
        {
            decimal finalSalary = this.Salary;

            if ( this.Team != null )
            {
                if ( this.Team.Count > 5 )
                {
                    finalSalary += 200;
                }
                else if ( this.Team.Count > 10 )
                {
                    finalSalary += 300;
                }

                ushort numberOfDevelopersInTeam = (ushort)this.Team.Where(e => e.GetType().Name == "Developer").Count();
                ushort numberOfTeammatesInTeam = (ushort)this.Team.Count;

                if ( numberOfDevelopersInTeam > (numberOfTeammatesInTeam / 2) )
                {
                    finalSalary *= 1.1m;
                }
            }

            return GetSalaryWithBonus(finalSalary);
        }
    }
}
