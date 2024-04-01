using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_17
{
    internal class PartTimeEmployee:Employee
    {
        public int HoursWorked { get; set; }
        public PartTimeEmployee(int id, string fullName, double salary, int hoursWorked) : base(id, fullName, salary)
        {
            HoursWorked = hoursWorked;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.Write("Hours Worked - ");
            Console.WriteLine(HoursWorked);
        }


    }
}
