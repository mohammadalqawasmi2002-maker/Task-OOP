using System;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee emp1 = new FullTimeEmployee(1, "Ahmad", 1200);

            PartTimeEmployee emp2 = new PartTimeEmployee(2, "Omar", 20, 20);

            emp1.DisplayInfo();
            emp1.Work();

            Console.WriteLine();

            emp2.DisplayInfo();
            emp2.Work();

            Console.ReadLine();
        }
    }
}