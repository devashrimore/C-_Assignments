using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1CSharp_Q3
{
    class Class1
    {
      
            public int add(params int[] numbers)
            {
                int result = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result = result + numbers[i];
                }
                return result;
            }
        }
        
    
}

