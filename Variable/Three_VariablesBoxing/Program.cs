﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_VariablesBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 100;
            object obj = m;//Boxing 
            //Console.WriteLine(obj);

            int n = (int)obj;// unboxing 
            Console.WriteLine(n);
            Console.ReadLine();

        }
    }
}
