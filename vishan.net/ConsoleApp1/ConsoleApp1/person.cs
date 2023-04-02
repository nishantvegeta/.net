using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class person
    {
        int NumberOfEyes;

        internal protected string HairColor { get; set; }

        internal protected int NumberOfEye { get { return NumberOfEyes; } set { NumberOfEyes = value; } }
}
}
