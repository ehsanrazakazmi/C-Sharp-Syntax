using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Tutorial
{
    class MethodParameters
    {
        static void MyMethod(string country = "Pakistan")   // parameter 'country' has a default value of "Pakistan" which is knows as optional parameter
        {
            Console.WriteLine(country);
        }
        static void Main(string[] args)
        {
            MyMethod("Australia");
            MyMethod("Newzealand");
            MyMethod("England");
            MyMethod();
        }
    }
}
