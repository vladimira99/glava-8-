﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to binary is {1}.",
                hexa, Convert.ToString(Convert.ToInt32(hexa, 16), 2));
        }
    }
}
