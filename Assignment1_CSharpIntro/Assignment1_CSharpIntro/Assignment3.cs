using System;
namespace A
{
    class Assignment3
    {
        public int add(params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i];
            }
            //Console.WriteLine("Addition of all numbers is:"+result);
            return result;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Assignment3 v = new Assignment3();
            int result = v.add(1, 2, 3, 7, 89);
            Console.WriteLine("Addition of all numbers is:" + result);
        }
    }
}