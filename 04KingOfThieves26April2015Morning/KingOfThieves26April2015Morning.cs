using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KingOfThieves26April2015Morning
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string(('-'), n / 2 - i),
                new string((symbol), 1 + 2 * i));
        }

        Console.WriteLine("{0}",
                new string((symbol), n));

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string(('-'), 1 + i),
                new string((symbol), n - ((1 + i) * 2)));
        }
    }
}