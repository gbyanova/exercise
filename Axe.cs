using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxeBradva
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('-', 3 * n));

                Console.Write('*');

                for (int i = 1; i <= row - 1; i++)
                {
                    Console.Write("-");
                }

                Console.Write("*");

                for (int j = 0; j < 2*n -row -1; j++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();
            }

            for (int row = 1; row <= n/2; row++)
            {
                Console.Write(new string('*', 3 * n + 1));

                Console.Write(new string('-', n - 1));

                Console.Write('*');

                Console.Write(new string('-', n - 1));

                Console.WriteLine();
            }

            //Console.Write(new string('-', 3 * n));

            //Console.Write('*');

            //Console.Write(new string('-', n - 1));

            //Console.Write('*');

            //Console.Write(new string('-', n - 1));

            //Console.WriteLine();


            for (int row = 0; row < n/2 - 1; row++)
            {
                for (int i = 0; i < 3*n - 1 - row; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");

                for (int j = 0; j <= n + 2 * row ; j++)
                {
                    Console.Write("-");
                }
                Console.Write("*");

                for (int i = 0; i < n - row - 2; i++)
                {
                    Console.Write("-");
                }

                Console.WriteLine();

                }

            


















            Main();

        }
    }
}
