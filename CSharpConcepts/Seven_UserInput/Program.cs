using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven_UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your First Name :");
            Console.Write(" write your First Name to reflect on the console :");
            string userName=Console.ReadLine();
            Console.WriteLine("What is your Last Name :");
            Console.Write("Write your Last Name to reflect on the console : ");
            string userName1=Console.ReadLine();
            Console.WriteLine("Hello {0},{1}", userName, userName1);
            Console.ReadLine(); 
            
        }
    }
}
