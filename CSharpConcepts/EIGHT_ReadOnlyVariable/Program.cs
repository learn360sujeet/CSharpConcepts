using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReadOnlyVariable
    {
        public readonly int myReadOnlyNum = 100;
        public readonly int myReadOnlyNum1;
    private int v;

    public ReadOnlyVariable(int v)
    {
        this.v = v;
    }

    public void ExampleNumber(int b)
        {
            int myReadOnlyNum1 = b * 100;
            Console.WriteLine(myReadOnlyNum1);
            Console.WriteLine(myReadOnlyNum);

        }
        
    }

    class Program
    {
          static void Main(string[] args) 
           {
               ReadOnlyVariable  obj= new ReadOnlyVariable (10);
                 Console.ReadLine();
           }
    }

