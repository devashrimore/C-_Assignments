﻿using System;
//using System.Collections.Generic;
//using System.Text;

namespace Assignment2OOP
{
        class Employee
        {
            int EmpNo;
            string EmpName;
            double Salary;
            double HRA;
            double TA;
        double DA;
        double PF;
        double TDS;
        double NetSalary;
        double GrossSalary;
        public int EMPNO { get; set; }

            public string EMPNAME { get; set; }
            public double SALARY { get; set; }
            public double HRA1 { get; set; }
            public double TA1 { get; set; }
            public double DA1 { get; set; }
            public double PF1 { get; set; }
            public double TDS1 { get; set; }
            public double NETSALARY { get; set; }
            public double GROSSSALARY { get; set; }



        //To initialize the data members of an class 
        //this 
         public Employee(int empno, string empname,double salary)
             {
                 this.EMPNO = empno;
                 this.EMPNAME = empname;
             this.SALARY = salary;
             }
        //Member fnctions
        public void CalculateSalary()
        {
            if(SALARY<5000)
            {
                HRA1 = SALARY / 10;
                TA1 = SALARY / 5;
                DA1= SALARY / 15;

            }
            else if(SALARY<10000)
            {
                HRA1 = SALARY / 15;
                TA1 = SALARY / 10;
                DA1 = SALARY / 20;

            }
            else if (SALARY < 15000)
            {
                HRA1 = SALARY / 20;
                TA1 = SALARY / 15;
                DA1 = SALARY / 25;

            }
            else if (SALARY < 20000)
            {
                HRA1 = SALARY / 25;
                TA1 = SALARY / 20;
                DA1 = SALARY / 30;

            }
            else if(SALARY >= 20000)
            {
                HRA1 = SALARY / 30;
                TA1 = SALARY / 25;
                DA1 = SALARY / 35;

            }
            GROSSSALARY = SALARY + HRA1 + TA1 + DA1;

            PF1 = GROSSSALARY / 10;

            TDS1 = GROSSSALARY / 18;

            NETSALARY = GROSSSALARY - (PF1 + TDS1);

        }
       



        }
       
   
}
