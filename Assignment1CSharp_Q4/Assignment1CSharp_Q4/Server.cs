using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1CSharp_Q4
{
    public class server
    {
        public int swap(int num1, int num2)
        {
            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping");
            Console.WriteLine("Number 1=" + num1);
            Console.WriteLine("Number 2=" + num2);
            return 0;
        }
    }
}
