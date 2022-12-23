using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Boxing__Unboxing_Variable
{/// <summary>
/// Boxing is the process of converting value type to refrence type 
/// Unboxing is the process of converting refrence type to value type 
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 100;
            object obj = m;//Boxing 
            //Console.WriteLine(obj);

            int n = (int )obj;// unboxing 
            Console.WriteLine( n ); 
            Console.ReadLine();


        }
    }
}
