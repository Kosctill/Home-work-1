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

        public Manager(string firstName, string lastName, decimal salary, byte efficiencyCoefficient, Manager manager, List<Employee> team)
                        : base(firstName, lastName, salary, efficiencyCoefficient, manager)
        {
            this.Team = team;
        }
    }
}
