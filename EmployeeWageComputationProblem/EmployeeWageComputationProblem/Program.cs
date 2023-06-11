using System;
namespace EmployeeWageComputationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the Employee Wage Problem");
            EmpWage employee = new EmpWage();
            employee.MonthlyEmpWage();
        }
    }
}