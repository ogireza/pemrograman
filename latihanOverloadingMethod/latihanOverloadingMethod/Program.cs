using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanOverloadingMethod
{
    class Program 
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Minimun #1: {0}", number.FindMin(3, 1));
            Console.WriteLine("Minimun #2: {0}", number.FindMin(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", number.FindMax(3, 1));
            Console.WriteLine("Maximum #2: {0}", number.FindMax(3, 2, 4));
            
            Console.ReadKey();
            //end
        }
    }
}
