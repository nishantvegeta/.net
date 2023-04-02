using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person Nishant = new person();
            Nishant.HairColor = "Black";
            Nishant.NumberOfEye = 2;
            Console.Write("Nishant has " + Nishant.HairColor + " color. ");
            Console.Write("Nishant has " + Nishant.NumberOfEye +  " eyes.");
            Console.ReadKey();

        }
    }
}
