using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of employees: ");
        int numEmployees = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of working days for each employee: ");
        int numWorkingDays = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the salary for day of  each employee: ");
        double salaryPerDay = Convert.ToDouble(Console.ReadLine());

        double[][] employeeSalaries = new double[numEmployees][];

        for (int i = 0; i < numEmployees; i++)
        {
            employeeSalaries[i] = new double[numWorkingDays];

            Console.WriteLine("\nEnter the daily salaries for employee {0}:", i + 1);
            for (int j = 0; j < numWorkingDays; j++)
            {
                Console.Write("Day {0}: ", j + 1);
                employeeSalaries[i][j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        Console.WriteLine("\nWeekly Salary Calculation:");
        Console.WriteLine("-------------------------");

        Console.WriteLine("Employee\t\t" + string.Join("\t", Enumerable.Range(1, numWorkingDays).Select(x => "Day " + x)));
        Console.WriteLine("----------------------------------------------------------------");

        for (int i = 0; i < numEmployees; i++)
        {
            double totalSalary = 0;

            Console.Write("Employee {0}\t\t", i + 1);

            for (int j = 0; j < numWorkingDays; j++)
            {
                Console.Write(employeeSalaries[i][j] + "\t");
                totalSalary += employeeSalaries[i][j];
            }

            Console.WriteLine(totalSalary);
        }

        Console.ReadLine();
    }
}