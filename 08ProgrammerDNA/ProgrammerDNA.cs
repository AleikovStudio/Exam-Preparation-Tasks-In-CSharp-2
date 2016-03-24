using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgrammerDNA
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        //char startingLetter = char.Parse(Console.ReadLine());

        int n = 7;
        char startingLetter = 'B';

        int dots = 3;
        int dotMultiplier = 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}",
            new string('.', dots),
            new string(startingLetter,1+2*i));
            dots -= dotMultiplier;

            if (dots==-1)
            {
                dots = 1;
                dotMultiplier *= -1;
            }
        }
    }
}