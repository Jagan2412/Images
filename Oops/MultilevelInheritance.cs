using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    //Real-world example: A class hierarchy for employees in a company.
    internal class MultilevelInheritance
    {
    }


    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }

        public void Work()
        {
            Console.WriteLine("Employee is working.");
        }
    }

    public class Manager : Employee
    {
        public string Department { get; set; }

        public void OrganizeTeam()
        {
            Console.WriteLine("Manager is organizing the team.");
        }
    }

    public class TeamLead : Manager
    {
        public void LeadTeam()
        {
            Console.WriteLine("Team lead is leading the team.");
        }
    }


}
