using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_VariableCasting
{/// <summary>
/// type conversion is said to be done when we assign the value of one data type to anotherf data type is called type conversion
///Data type has to be compatible with each other . 
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 100;// Implicit conversion or Automatic Type conversion 
            int c = b;
            //Console.WriteLine(c);

            long D = 200;//Explicit type of conversion is said to be done when conversion taking place from larger 
             //data type to smaller data type .//it is also called type casting .//Data may or may not loose 
            int e = (int)D;
            //Console.WriteLine(e);

            ///Conversion taking place between non compatible one ,
            string s = "12345";
            int n =Convert.ToInt32(s);//we can convert non compatible with the help of CONVERT .TOINT32
            Console.WriteLine(n);


            Console.ReadLine();
        }
    }
}
