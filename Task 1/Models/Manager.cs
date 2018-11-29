using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Models
{
    /// <summary>
    /// It's class is inherited from Employee class and represents Manager entity
    /// </summary>
    public class Manager : Employee
    {
        /// <summary>
        /// Team developers and designers 
        /// </summary>
        public List<Employee> Team { set; get; }

        /// <summary>
        /// This cosntructor makes initial initialization of the Manager entity
        /// </summary>
        /// <param name="firstName">First name of the manager</param>
        /// <param name="lastName">Last name of the manager</param>
        /// <param name="salary">Salary of the manager</param>
        /// <param name="experience">Experience of the manager</param>
        /// <param name="manager">Appropriate manager of the manager</param>
        /// <param name="team">Team </param>
        public Manager ( string firstName, string lastName, decimal salary,
                         byte experience, Manager manager, List<Employee> team ) :
                         base ( firstName, lastName, salary, experience, manager )
        {
            this.Team = team;
        }

        /// <summary>
        /// Calculates salary depending of the size of team
        /// </summary>
        /// <returns>Total salary with bonuses</returns>
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
