using System;

namespace Assignment1CSharp_Q3
{
    class Program
    {
        
            public static void Main(string[] args)
            {
                Class1 v = new Class1();
                int result = v.add(1, 2, 3, 7, 89);
                Console.WriteLine("Addition of all numbers is:" + result);
            }
        
    }
}
