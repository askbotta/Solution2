using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigos
{
    internal class BoxingUnBoxing
    {
        static void Main()
        {
            int iii = 100;
            Object obt = iii;  // implicit conversion or boxing // reference value
            int j = (int)obt;
            
            Console.WriteLine(j);
            
            
            double d = 12.34;
            int myInt = (int)d; // explicitly converted
            Console.WriteLine(myInt);
            Console.ReadLine();

        }

    }
}
