using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input your number");
                string myNumber = Console.ReadLine();
                int mynumber = Convert.ToInt32(myNumber);
                Console.WriteLine("Your number is" + mynumber);
                string[] names = new string[5];
                names[0] = "nish";
                names[1] = "sush";
                names[2] = "miss";
                names[3] = "kris";
                names[4] = "tiny";
                names[5] = "babe";
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
