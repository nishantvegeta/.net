using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatype
{
    internal class Program
    {
        static void Main()
        {
            // logicalOperator();
            Bitwise();
            Console.ReadKey();

        }
       /* static void logicalOperator()
        {
            Console.WriteLine("Enter your college");
            string colgName=Console.ReadLine();
            Console.WriteLine("Enter your program");
            string program=Console.ReadLine();
            if (colgName.ToUpper() == "BMC" && program.ToUpper() =="CSIT") {
                Console.WriteLine("You are welcome to lab");
            }
            else{
                Console.WriteLine("You may not enter to the Lab");
            }

        }*/
        static void Bitwise()
        {
            Console.WriteLine("Enter first number");
            int a = Console.ReadLine();
            Console.WriteLine("Enter Second number");
            int b=Console.ReadLine();
            Console.WriteLine(a & b);

        }
    }
}
