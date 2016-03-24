using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}",
            new string('.', ((n * 2 - 1) - n) / 2),
            new string('#', n));//1ST PART - STATIC


        for (int i = 0; i < n - 2; i++)//2ND PART
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.', n / 2),
                new string('#', 1),
                new string('.', n - 2));
        }

        Console.WriteLine("{0}{1}{0}",
            new string('#', n / 2 + 1),
            new string('.', ((n * 2 - 1) - 2 * (n / 2 + 1))));//3RD PART - STATIC

        for (int i = 0; i < n - 2; i++)//4TH PART
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.', i + 1),
                new string('#', 1),
                new string('.', ((n * 2 - 1) - 4 - (i*2))));
        }
        Console.WriteLine("{0}{1}{0}",
            new string('.',n-1),
            new string('#', 1));//5TH PART - STATIC
    }
}