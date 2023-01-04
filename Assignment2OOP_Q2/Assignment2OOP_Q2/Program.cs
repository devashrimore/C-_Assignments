using System;

namespace Assignment2OOP_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Emloyee details:");
                Console.WriteLine("Emp No:");
                int eno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Emp Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Salary:");
                double sal = Convert.ToDouble(Console.ReadLine());



                if (eno < 0 || eno == 0 || sal < 0 || sal == null || name == null)
                {
                    Console.WriteLine("Error: Please check your details... emp no,name and salary can not be zero or null");

                }
                else
                {
                    Employee emp = new Employee(eno, name, sal);
                    emp.CalculateSalary();
                    emp.displayDetails();
                }
            }
            catch (Exception emp)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
