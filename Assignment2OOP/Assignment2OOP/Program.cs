using System;

namespace Assignment2OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //public void Accept()
           
                Console.WriteLine("Enter Emloyee details:");
                Console.WriteLine("Emp No:");
                int eno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Emp Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Salary:");
                double sal = Convert.ToDouble(Console.ReadLine());
         

           
                Employee emp = new Employee(eno,name,sal);

                emp.CalculateSalary();


                Console.WriteLine("\nThe Emp NO is      :  " + emp.EMPNO);
                Console.WriteLine("\nThe Emp Name is    :  " + emp.EMPNAME);
                Console.WriteLine("\nThe salary is      :  " + emp.EMPNAME);
                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine("\nThe  HRA is        :  " + emp.HRA1);
                Console.WriteLine("\nThe TA is          :  " + emp.TA1);
                Console.WriteLine("\nThe  DA is         :  " + emp.DA1);
                Console.WriteLine("\nThe Gross Salary is:  " + emp.GROSSSALARY);
                Console.WriteLine("\nThe  PF is         :  " + emp.PF1);
                Console.WriteLine("\nThe TDS is         :  " + emp.TDS1);
                Console.WriteLine("\nThe  Net Salary is :  " + emp.NETSALARY);

           




            //How to access the Methods outside the class
           // emp.DisplayEmpDetails();
            //Console.ReadKey();



        }
    }
}
