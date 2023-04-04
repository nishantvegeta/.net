using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_constructordestructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cow = new Animal();
            cow.WhatIEat();
            Animal dog = new Animal("Dog");
            dog.WhatIEat("Bone");
            Console.ReadKey();
        }
    }
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("I am animal. ");
        }
        public void WhatIEat()
        {
            Console.WriteLine("I eat grass.");
        }
        public Animal(String name)
        {
            Console.WriteLine("I am " + name);
        }
        public void WhatIEat(string food)
        {
            Console.WriteLine("I eat " + food);
        }
        ~Animal() 
        {

        }
    }

}
