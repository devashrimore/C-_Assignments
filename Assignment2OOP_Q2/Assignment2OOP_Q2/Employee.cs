using System;


namespace Assignment2OOP_Q2
{
    class Employee
    {

        int EmpNo;
        string EmpName;
        double Salary;
        double HRA;
        double TA;
        double DA;
        double GrossSalary;
        /*public int EMPNO { get; set; }

        public string EMPNAME { get; set; }
        public double SALARY { get; set; }
        public double HRA1 { get; set; }
        public double TA1 { get; set; }
        public double DA1 { get; set; }
        public double PF1 { get; set; }
        public double TDS1 { get; set; }
        public double NETSALARY { get; set; }
        public double GROSSSALARY { get; set; }*/



        //To initialize the data members of an class 
        //this 
        public Employee(int empno, string empname, double salary)
        {
            this.EmpNo = empno;
            this.EmpName = empname;
            this.Salary = salary;
        }
        //Member fnctions
        public void CalculateSalary()
        {
            if (Salary < 5000)
            {
                HRA = Salary / 10;
                TA = Salary / 5;
                DA = Salary / 15;

            }
            else if (Salary < 10000)
            {
                HRA = Salary / 15;
                TA = Salary / 10;
                DA = Salary / 20;

            }
            else if (Salary < 15000)
            {
                HRA = Salary / 20;
                TA = Salary / 15;
                DA = Salary / 25;

            }
            else if (Salary < 20000)
            {
                HRA = Salary / 25;
                TA = Salary / 20;
                DA = Salary / 30;

            }
            else if (Salary >= 20000)
            {
                HRA = Salary / 30;
                TA = Salary / 25;
                DA = Salary / 35;

            }
            GrossSalary = Salary + HRA + TA + DA;


        }
        public void displayDetails()
        {

            Console.WriteLine("\nThe Emp NO is      :  " + EmpNo);
            Console.WriteLine("\nThe Emp Name is    :  " + EmpName);
            Console.WriteLine("\nThe salary is      :  " + Salary);
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("\nThe  HRA is        :  " + HRA);
            Console.WriteLine("\nThe TA is          :  " + TA);
            Console.WriteLine("\nThe  DA is         :  " + DA);
            Console.WriteLine("\nThe Gross Salary is:  " + GrossSalary);

        }
    }
}
