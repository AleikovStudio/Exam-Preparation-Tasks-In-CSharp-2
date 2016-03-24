using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TravellerBob19December2014
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        decimal contractsMonths = decimal.Parse(Console.ReadLine());//per month = 12
        decimal familyMonths = decimal.Parse(Console.ReadLine());//per month = 4

        decimal contractFlights = contractsMonths * 12;
        decimal familyFlights = familyMonths * 4;
        decimal normalFlights = ((12 - (contractsMonths + familyMonths)) * 12) * 0.6m;

        decimal yearLeapFlights = (contractFlights + familyFlights + normalFlights) + ((contractFlights + familyFlights + normalFlights) * 0.05m);
        decimal yearNormalFlights = contractFlights + familyFlights + normalFlights;

        switch (yearType)
        {
            case "leap":
                Console.WriteLine(Math.Floor(yearLeapFlights));
                break;
            case "normal":
                Console.WriteLine(Math.Floor(yearNormalFlights));
                break;
        }
    }
}