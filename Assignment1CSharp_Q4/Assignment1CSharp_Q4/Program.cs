using System;

namespace Assignment1CSharp_Q4
{
    public class client
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the Numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping:");
            Console.WriteLine("Number 1=" + num1);
            Console.WriteLine("Number 2=" + num2);
            server s = new server();
            s.swap(num1, num2);
        }
    }
}

