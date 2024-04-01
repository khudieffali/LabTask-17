using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_17
{
    internal class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public double Salary { get; set; }
        public Employee(int id,string fullName,double salary)
        {
            ID = id;
            FullName = fullName;
            Salary = salary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name" + " ID" + " Salary");
            Console.WriteLine(FullName+" "+ID+" "+Salary);
        }
    }
}
