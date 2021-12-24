using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Silnia1
{

    class Silnia
    {

        static BigInteger silnia(BigInteger n)
        {
            BigInteger result = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }


        static void Main(string[] args)
        {
            String line;
            BigInteger n;

            Console.WriteLine("Podaj dla jakiej liczby obliczyc silnie.\n");
            line = Console.ReadLine();
            n = BigInteger.Parse(line);

            Console.WriteLine(n + "! = " + silnia(n));
            Console.WriteLine("Podaj dla jakiej liczby obliczyc silnie.\n");
            line = Console.ReadLine();
            n = BigInteger.Parse(line);

            Console.WriteLine(n + "! = " + silnia(n));
            Console.WriteLine("Podaj dla jakiej liczby obliczyc silnie.\n");
            line = Console.ReadLine();
            n = BigInteger.Parse(line);

            Console.WriteLine(n + "! = " + silnia(n));
            Console.ReadLine();
        }
    }
}

