using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList mylist = new ArrayList();
            mylist.Add("BMC");
            mylist.Add(9818);
            mylist.Add(true);
            foreach (var item in mylist) 
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }*/
            //non-generic_collection
            /*Hashtable mylist = new Hashtable();
            mylist.Add("College", "BMC");
            mylist.Add("milk", true);
            mylist.Add("mobile", 9818);
            foreach (var item in mylist.Keys) 
            {
                Console.WriteLine("key is "+ mylist[item] );
            }
            Console.ReadKey();
        }*/

            //generic collection
            /* List<int> RollNo = new List<int>();
             RollNo.Add(101);
             RollNo.Add(102);
             RollNo.Add(103);
             foreach (int item in RollNo) 
             {
                 Console.WriteLine("Roll no. is "+ item);
             }
             Console.ReadKey();
         }*/

            FileStream file = new FileStream("nish.dat",FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //file.WriteByte((byte)10);
            Console.WriteLine(file.ReadByte()+" ");
            file.Close();
            Console.ReadKey();       
        }
        
        
    }
}
