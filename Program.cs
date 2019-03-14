using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoav_Faran
{
    class Program
    {
        static void Main(string[] args)
        {
            //question one - part 1
            Console.WriteLine("enter a number between 0 to 1000 (prime number check)");
         int x = Convert.ToInt32(Console.ReadLine());
            while (x > 1000 || x < 0)
            {
                Console.WriteLine("enter a number between 0 to 1000 (prime number check)");
                x = Convert.ToInt32(Console.ReadLine());
            }
            if (x == 1)
            {
                Console.WriteLine("This is NOT a prime number");
            }
            else
            {
                int i = 2;
                while (x % i != 0)
                {
                    i++;
                }
                if (i == x)
                {
                    Console.WriteLine("This is Prime");
                }
                else
                {
                    Console.WriteLine("This is NOT a prime number");
                }
            }
        }
    }
}
