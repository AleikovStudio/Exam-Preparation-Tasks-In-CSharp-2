using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Striped_Towel
{
    class StripedTowel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = n;
            int height = n + n / 2;

            for (int cols = 0; cols < height; cols++)
            {
                for (int rows = 0; rows < width; rows++)
                {
                    if ((rows + cols) % 3 == 0)
                    {
                        Console.Write("#");
                    }
                    else if ((rows + cols) % 3 != 0)
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
