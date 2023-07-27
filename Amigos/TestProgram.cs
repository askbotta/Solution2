using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigos
{
    internal class TestProgram
    {
        //creating instance another class //july 4th
        public void CallMethods()
        {
            Program p = new Program();
            p.Test1();
            Console.WriteLine();
            p.Test2(9, 12);
            Console.WriteLine();
            Console.WriteLine(p.Test3());
            Console.WriteLine(p.Test4("hello america"));
        }
            static void Main()
            {
                new TestProgram().CallMethods();    // unnamed instance
                 Console.ReadLine();
            }
        
    }
}
