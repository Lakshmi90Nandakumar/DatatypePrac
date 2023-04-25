using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypePrac
{
    internal class DataTypePractise
    {
        static void main(string[] args)
        {

            int a= -19;
            uint b = 190;
            short c = 90;
            bool bl=true;
            long l=4000000;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);   
            Console.WriteLine(bl);
            Console.WriteLine(l);
            Oper();

        }
        static void Oper()
        {
            int a = 39;
            long b = 4000;
            long c = a + b;
            Console.WriteLine("Addition value is: "+c);
            Console.WriteLine(a-b);
        }
    }
}
