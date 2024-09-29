using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_Tutorial
{
    internal class ArrayEx1
    {
        static void Main(string[] args)
        {
            /*
            string[] fraudulentOrderIDs = new string[3];    // here we have initialized an array of 3 exact elements all of them will be of data type = string
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            //fraudulentOrderIDs[3] = "D000";
            */
            string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0].Length}");

            foreach (string fraud in fraudulentOrderIDs)
            {
                Console.WriteLine(fraud);
            }
            Console.WriteLine("\n\n\n");

            int[] inventory = [200, 450, 700, 157, 542];
            int sum = 0;
            int flag = 0;
            
            foreach (int i in inventory)
            {
                sum += i;       // sum = sum + i
                flag++;
                Console.WriteLine($"Bin {flag} = {i} items (Running total: {sum})");
            }
            Console.WriteLine($"{flag} : {sum}");










        }

    }
}
