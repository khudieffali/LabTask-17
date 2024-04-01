
using LabTask_17;

internal class Program
{
    private static void Main(string[] args)
    {

        FullTimeEmployee employee1 = new(152, "Selver Cafarov", 1000,30);
        FullTimeEmployee employee2 = new(152, "Ali Cafarov", 1500,45);
        PartTimeEmployee employee3 = new(152, "Selver Cabbarli", 1700,300);
        PartTimeEmployee employee4 = new(152, "Pasha Cafarov", 1300,200);
        Employee[] empArr = { employee1, employee2, employee3, employee4 };

        for (int i = 0; i < empArr.Length; i++)
        {
            empArr[i].DisplayInfo();
        }

    }
}