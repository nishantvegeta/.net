using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Indexer indexer = new Indexer();
            indexer[0] = "asd";
            indexer[1] = "dsa";
            indexer[2] = "aad";
            indexer.College = "BMC";
            for (int counter=0; counter<=2; counter++)
            {
                Console.WriteLine(indexer[counter]);
            }
            Console.ReadKey();
        }
    }
}
