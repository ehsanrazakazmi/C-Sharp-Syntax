using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Tutorial
{
    internal class Ex
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 5;

            Console.WriteLine((float)a / (float)b);
            Console.WriteLine((a+b)*c);
            Console.WriteLine(!(a != c));       // !True = Flase
            Console.WriteLine(c>b && c==a);     // true && false = flase
        }
    }
}
