using System;
using System.Collections.Generic;
﻿using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new List<int>{ 1,2,3 };
            a.Select(e => e*e);
        }
    }
}
