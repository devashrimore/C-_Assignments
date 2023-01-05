using System;

namespace Assignment1CSharp_Q5
{ 
    public class client
    {
        public static void Main(string[] args)
        {
            server s = new server();
            Console.WriteLine("Enter the radius of circle");
            double r = Convert.ToDouble(Console.ReadLine());
            double a1 = s.area(r);
            Console.WriteLine("Area of Circle is:" + a1);
            double c1 = s.circum(r);
            Console.WriteLine("Circumference of Circle is:" + c1);
        }
    }
}

