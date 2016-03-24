using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BookProblemStefan26April2015Morning
{
    static void Main()
    {
        decimal pagesToRead = decimal.Parse(Console.ReadLine());//250.000
        decimal holidaysPerMonth = decimal.Parse(Console.ReadLine());//5
        decimal pagesPerDay = decimal.Parse(Console.ReadLine());//10

        decimal daysToRead = 30 - holidaysPerMonth;//25

        if (holidaysPerMonth >= 30)
        {
            Console.WriteLine("never");
            return;
        }
        
        decimal PagesReadPerMonth = pagesPerDay * daysToRead;//250
        decimal whenFinish = pagesToRead / PagesReadPerMonth;//250.000/250 = 1000 months

        decimal years = Math.Floor(whenFinish / 12);//years
        decimal months = Math.Ceiling(whenFinish % 12);//months

        Console.WriteLine("{0} years {1} months", years, months);
    }
}