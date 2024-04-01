using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_17
{
    internal class FullTimeEmployee:Employee
    {
        public int VacationDays { get; set; }
        public FullTimeEmployee(int id,string fullName,double salary,int vacationDays):base(id,fullName,salary)
        {

            VacationDays = vacationDays;

        }
        public override void DisplayInfo()
        {
             base.DisplayInfo();
            Console.Write("Vacation Days - ");
            Console.WriteLine(VacationDays);
        }
    }
}
