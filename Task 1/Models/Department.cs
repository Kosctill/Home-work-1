using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_1.Models
{
    /// <summary>
    /// This class contains list managers with their team
    /// </summary>
    public class Department
    {
        /// <summary>
        /// List of managers
        /// </summary>
        public List<Manager> Managers { set; get; }

        /// <summary>
        /// Accepts a initial list managers for initialiations
        /// </summary>
        /// <param name="managers"></param>
        public Department ( List<Manager> managers )
        {
            this.Managers = managers;
        }

        /// <summary>
        /// Give salary every managers and every employees with their team
        /// </summary>
        public void GiveSalary()
        {
            if ( this.Managers != null )
            {
                ushort numberManagerAndTeam = 1;
                foreach (Manager manager in this.Managers)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Manager {numberManagerAndTeam}:\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{manager.FirstName} {manager.LastName}: got salary: {manager.GetSalary()}$\n");

                    if ( manager.Team != null )
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Team {numberManagerAndTeam}: \n");
                        Console.ForegroundColor = ConsoleColor.Green;

                        foreach (Employee teammate in manager.Team)
                        {
                            Console.WriteLine($"{teammate.FirstName} {teammate.LastName}: got salary: {teammate.GetSalary()}$");
                        }
                        Console.WriteLine();
                    }
                    numberManagerAndTeam++;
                }
            }   
        }
    }
}
