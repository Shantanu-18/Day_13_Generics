﻿using System;

namespace Day_13_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(11.7, 26.47, 70.56);
            Console.WriteLine(doubleoutput);
            string strigoutput = MaximumNumberCheck.MaximumStringNumber("apple", "mango", "grapes");
            Console.WriteLine(strigoutput);
        }
    }
}
