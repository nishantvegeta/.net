using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_delegate
{
    internal class Program
    {
        public delegate void WhatIEat();
        public delegate void WhatIEats(string food);
        static void Main(string[] args)
        {
            Animal cow = new Animal();
            Animal dog = new Animal();
            WhatIEat eat = new WhatIEat(cow.WhatIeat);
            WhatIEats eats = new WhatIEats(dog.WhatIeat);
        eat();
        eats("Bone");
            Console.ReadKey();  
        }
    }
    public class Animal
    {
        public void WhatIeat() 
        {
            Console.WriteLine("I eat grass. ");
        }
        public void WhatIeat(string food) 
        {
            Console.WriteLine("I eat "+ food);
        }
    }
}
