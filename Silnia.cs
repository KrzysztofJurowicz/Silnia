using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace silnia
{
    
    class Silnia
    {

        private static int silnia(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }


        static void Main(string[] args)
        {
            String line;
            int n;

            Console.WriteLine("Podaj dla jakiej liczby obliczyc silnie.\n");
            line = Console.ReadLine();
            n = int.Parse(line);

            Console.WriteLine(n + "! = " + silnia(n));
            Console.ReadLine();
        }
    }
}


