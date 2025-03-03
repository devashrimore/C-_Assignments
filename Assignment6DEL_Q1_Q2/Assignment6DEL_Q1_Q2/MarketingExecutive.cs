﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1
{
    class MarketingExecutive : Employee, IPrintable
    {
        int empId;
        string empName, location;

        double empSal;
        double km, tour_A, tele_A, gs, pf, tds, netsal;
        public MarketingExecutive(int empId, string empName, double empSal, double km) : base(empId, empName, empSal)
        {
            this.empId = empId;
            this.empName = empName;
            this.empSal = empSal;
            this.km = km;
        }
        public override void CalGrossSal()
        {
            base.CalGrossSal();
            tour_A = 5 * this.km;
            tele_A = 1000;

            gs = this.grossSal + tour_A + tele_A;

        }

        public override void CalculateSal()
        {
            pf = this.pf + gs / 10;

            tds = this.tds + gs / 18;

            netsal = gs - (pf + tds);
        }

        public void info()
        {
            Console.WriteLine("Marketive Executive  Details are-------");

            Console.WriteLine("Km employee travel = {0} ", km);
            Console.WriteLine("Marketive Executive  GrossSalary= {0} ", gs);
            Console.WriteLine("Marketive Executive  NetSalary= {0} ", netsal);
            Console.WriteLine("---------------------------------");

        }
    }
}
/*public void info()
{

    Console.WriteLine("\nEmployee Id = " + ID + "\nEmployee Name = " + Name +
    "\nDate of Joining = " + JoiningDt + "\nDepartment = " + department + "\npetrol Allowance = " + PetrolAllowance + "" +
    "\nCommision = " + commission + "\nTotal Salary = " + CalculateSalary());


}*/


