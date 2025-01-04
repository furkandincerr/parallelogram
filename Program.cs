using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parallelogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            for (int i = 1; i <= 8; i++)
            {
                for (int k = 1; k <= b; k++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= 8; j++)
                {

                    if (i == 1 || i == 8)
                    {
                        Console.Write("* ");
                    }



                    else if (j == 1 || j == 8 || j == 8 - b)
                    {
                        Console.Write("* ");
                    }

                    else if (i == j)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write("\n");
                b++;
            }
        }
    }
}
