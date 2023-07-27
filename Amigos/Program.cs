using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigos
{
    internal class Program
    {
        public void Test1()     // when we use void key word then it is called non value returning
        {
            //non value returning method without parameters
            int x = 5;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine ($"{x}*{i}={x*i}");
            }

        }
           //non value returning methos with parameters
           public void Test2 (int x,int ub)
        {
            for (int i = 1; i <= ub;i++)
            {
                Console.WriteLine ($"{x}*{i}={x*i}");
            }
        }
          // value returning method without parameters
          
           public string Test3()
        {
            string str = "hello world";
            str = str.ToUpper ();
            return str;
        }
          //value returnig method with parameters

           public string Test4(string str)
        {
            str = str.ToUpper ();
            return str;
        }
          static void Main()
        {
            Program P = new Program ();

            // calling non value returning methods

            P.Test1 ();
            Console.WriteLine();

            P.Test2 (8,15);
            Console.WriteLine();

            // calling value returning methods

            string S1 = P.Test3 ();
            Console.WriteLine (S1);


            string s2 = P.Test4("hello india");
            Console.WriteLine (s2);
            Console.ReadLine ();
        }
    }
}
