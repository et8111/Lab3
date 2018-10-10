using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab3
{
    class Program
    {
          static string choice(int num)
          {
            if (num % 2 == 0 && num > 60)
                return num.ToString() + ", and Even.";
            else if (num % 2 != 0)
                return num.ToString() + ", and Odd.";
            else if
                (num > 25 && num < 61)
                return "Even.";
            else if (num % 2 == 0 && (num <= 25 && num >= 2))
                return "Even and less then 25.";
            return "ERROR.";
          }

        static void Main(string[] args)
        {
            string test;
            int num;
            while (true)
            {
                try
                {
                    Console.Write("Enter a Number: ");
                    num = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("SHIT CODE");
                    Console.WriteLine(e.Message);
                    continue;
                }
                if (num < 1 || num > 100)
                {
                    Console.WriteLine("Invalid Entry (1-100)");
                    continue;
                }
                Console.WriteLine(choice(num));
                Console.Write("\nPress 'y' to go again, any key to exit?: ");
                test = Console.ReadLine();
                if (test == "y")
                    Console.WriteLine();
                else
                    break;
            }
            Console.WriteLine("End.");
        }
    }
}
