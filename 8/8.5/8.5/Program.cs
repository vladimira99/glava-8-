﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.Write("Enter binary number: ");
                string binary = Console.ReadLine();
                Console.WriteLine("{0} to decimal is {1}.",
                    binary, Convert.ToInt64(binary, 2));
            }
        
    }
}
