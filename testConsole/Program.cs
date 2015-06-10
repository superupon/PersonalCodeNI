using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    public class Program
    {
        enum WhatEver
        {
            HALO = 0,
            hello = 1,
        };
        static void Main(string[] args)
        {
            Console.WriteLine(((WhatEver)0).ToString());
            int j = Program.Add(4, 5);
        }
        public static int Add(int a, int b)
        { 
            return a + b;
        }
        public void HaHa(string str)
        {
            Console.WriteLine( "Haha");
        }
    }
}
