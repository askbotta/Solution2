using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigos
{
    internal class TennaryOperators
    {
        static void Main()
        {
            int i = 100;
            int j = 200;

            int max = i < j ? i : j;  // condition ? expression1 : expression2 

            Console.WriteLine(max);
            

            int num = 10;
            string result = num > 0 ? "Positive" : "Negative";
            Console.WriteLine(result);
            Console.ReadLine();



        }
    }
}
