using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static string choice()
            {
            Console.Write("Enter a Number: ");
            int num = int.Parse(Console.ReadLine());
            string s = "";

            if (num % 2 == 0 && num > 60)
                s = num.ToString() + ", and Even.";
            else if (num % 2 != 0)
                s = num.ToString() + ", and Odd.";
            else if
                (num > 25 && num < 61)
                s = "Even.";
            else if (num % 2 == 0 && (num <= 25 && num >= 2))
                s = "Even and less then 25.";
            
            return s;
            }
        static void Main(string[] args)
        {
            string test = "y";
            while (test == "y")
            {
                Console.WriteLine(choice());
                Console.Write("\nAgain (y/n)?: ");
                test = Console.ReadLine();
                if (test == "y")
                    Console.WriteLine();
            }

            Console.WriteLine("End.");
        }
    }
}
