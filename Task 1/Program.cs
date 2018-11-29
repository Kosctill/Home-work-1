using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Models;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var managers = new List<Manager>
            {
                new Manager ( "Ivan", "Ivanov", 700, 4, null, null ),
                new Manager ( "Petro", "Petrov", 900, 7, null, null ),
                new Manager ( "Richard", "Richardov", 1100, 11, null, null )
            };
            InitializeOfCommandsManagers(ref managers);

            Department department = new Department ( managers );

            Console.WriteLine("Giving the salaries: \n");
            department.GiveSalary();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("All managers: \n");
            Console.ForegroundColor = ConsoleColor.Green;
            foreach ( Manager manager in department.Managers )
            {
                Console.WriteLine(manager);
            }

            Console.ReadKey();
        }

        static void InitializeOfCommandsManagers ( ref List<Manager> managers )
        {
            managers[0].Team = new List<Employee>
            {
                new Developer ( "Mikle", "Miklov", 1500, 3, managers[0] ),
                new Developer ( "Andriy", "Andriyov", 800, 1, managers[0] ),
                new Designer ( "John", "Johnov", 900, 2, managers[0], 1.2f )
            };

            managers[1].Team = new List<Employee>
            {
                new Developer ( "Olexandr", "Olexandrov", 2000, 5, managers[1] ),
                new Developer ( "Artem", "Artemov", 1800, 3, managers[1] ),
                new Developer ( "Pete", "Petov", 500, 0, managers[1] ),
                new Developer ( "Myklailo", "Myklailov", 800, 1, managers[1] ),
                new Designer ( "Nazar", "Nazarov", 1000, 2, managers[1], 0.8f ),
                new Designer ( "Yura", "Yurov",  1500, 5, managers[1], 1.3f)
            };

            managers[2].Team = new List<Employee>
            {
                new Developer ( "Yaroslav", "Yaroslavov", 1500, 3, managers[2] ),
                new Developer ( "Eugene", "Eugenov", 1000, 2, managers[2] ),
                new Developer ( "Bohdan", "Bohdanov", 800, 1, managers[2] ),
                new Designer ( "Olexsiy", "Olexsiyovych", 1500, 3, managers[2], 1.7f )
            };
        }
    }
}
