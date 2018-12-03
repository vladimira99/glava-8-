using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int deci = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} to binary is {1}.", deci, deci.ToString());
        }
    }
}
