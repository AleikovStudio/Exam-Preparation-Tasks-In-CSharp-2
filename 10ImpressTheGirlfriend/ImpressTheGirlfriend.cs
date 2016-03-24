using System;
using System.Linq;

class ImpressTheGirlfriend
{
    static void Main()
    {
        decimal rubles = decimal.Parse(Console.ReadLine());
        decimal dollars = decimal.Parse(Console.ReadLine());
        decimal euro = decimal.Parse(Console.ReadLine());
        decimal bgOne = decimal.Parse(Console.ReadLine());
        decimal bgTwo = decimal.Parse(Console.ReadLine());

        decimal rublesLv = rubles * 0.035m;
        decimal dollarsLv = dollars * 1.5m;
        decimal euroLv = euro * 1.95m;
        decimal bgOneConv = bgOne / 2;

        decimal[] array = new[] { rublesLv, dollarsLv, euroLv, bgOneConv, bgTwo };

        Console.WriteLine("{0:f2}", Math.Ceiling(array.Max()));
    }
}