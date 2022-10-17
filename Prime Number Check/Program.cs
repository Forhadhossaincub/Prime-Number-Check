using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 10;

            Console.WriteLine($"Prime Number : {Prime(x)}");

            Console.ReadKey();

            Console.ReadKey();

        }

        public static bool Prime(int x)
        {
            bool prime = true;

            for (int i = 2; i < x / 2; i++)
            {
                if (x % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            return prime;
        }
    }
}
