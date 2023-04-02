using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal();
            cow.WhatIEat();
            cow.WhatIEat("momo");
            cow.WhatIEat("momo", "water");
            Console.ReadKey();  
        }
    }
}
