using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Amigos
{
    internal class Convert  // internal modifier
    {
        static void Main()
        {
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9


        }

    }
}
