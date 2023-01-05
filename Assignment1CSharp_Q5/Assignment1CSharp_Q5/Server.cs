using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1CSharp_Q5
{
    public class server
    {
        const double pie = 3.14F;
        public double area(double r)
        {
            double a = pie * (r * r);
            return a;
        }
        public double circum(double r)
        {
            double c = 2 * pie * r;
            return c;
        }
    }
}
