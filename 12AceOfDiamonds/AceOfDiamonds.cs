using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AceOfDiamonds
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}",new string('*', n));

        for (int rows = 0; rows < n; rows++)
        {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string('*',1),
                        new string('-',(n/2-1)-rows),
                        new string ('@',1+(2*rows)));
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string('*',1),
                        new string('-',1+(1*rows)),
                        new string('@',(n-4-(2*rows))));

        }
        Console.WriteLine("{0}",new string('*', n));
    }
}