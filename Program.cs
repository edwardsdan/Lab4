using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 1 to 20");
            int Input = int.Parse(Console.ReadLine());

            // for loop
            long a = Input;
            for (long i = Input; i > 1; i--)
            {
                a *= (i-1);
            }
            Console.WriteLine($"{Input}! = {a}");

            // recursive call
            Console.WriteLine($"{Input}! = {CalcPower(Input)}" );

            Console.WriteLine("Continue? (y/n)");
            string response = Console.ReadLine();
            if (response.ToLower() == "y" || response.ToLower() == "yes")
            {
                Console.Clear();
                Main(args);
            }
            else
                Console.WriteLine("Goodbye!");
        }

        public static long CalcPower(int x)
        {
            if (x == 1)
                return 1;
            else
                return x * CalcPower(x - 1);
        }
    }
}
