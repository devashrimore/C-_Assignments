﻿using System;

namespace Assignment3OOP_Q2
{
        class Program
        {
            static void Main()
            {
                MyStack S = new MyStack(5);
            MyStack C = (MyStack)S.Clone();

               C.push(10);
               C.push(20);
               C.push(30);
               C.push(40);
               C.push(50);

                Console.WriteLine("Items are : ");
            C.printStack();
            C.pop();
            C.pop();
            C.pop();

            Console.WriteLine("Items are : ");
            C.printStack();
        }
        }
    
}
