using System;
namespace EmployeeWageComputationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Problem");
            EmpWage employee = new EmpWage();
            employee.DailyEmployeeWage();
        }
    }
}