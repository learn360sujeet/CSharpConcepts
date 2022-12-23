using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Five_Global_Local_Variable
{/// <summary>
/// Variables declared outside the function s are called global variable .
/// variables declared with  the keyword static is called static variable.
/// </summary>
/// 
    class Program
    {
        
        public static void Main(string[] args) 
        {
            int a = 10;
            Console.WriteLine(a);
            //local variable//Variables that are declared inside the function is called local variable
            Console.ReadLine(); 
        }



       
    }
}
