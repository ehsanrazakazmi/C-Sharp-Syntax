using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mosh_Tutorial
{
    internal class ForeachChallenge
    {
        static void Main(string[] args)
        {
            string[] FOrderID = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
            foreach (string F in FOrderID)
            {
                if (F.StartsWith("B"))
                {
                    Console.WriteLine(F);
                }
            }
        }
    }
}
