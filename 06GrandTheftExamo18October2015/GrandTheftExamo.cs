using System;

class GrandTheftExamo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal[] inputArray = new decimal[n * 2];

        for (int i = 0; i < n * 2; i++)
        {
            inputArray[i] = decimal.Parse(Console.ReadLine());
        }

        decimal thievesAll = 0;
        decimal beersAll = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (i % 2 == 0)
            {
                thievesAll += inputArray[i];
            }
            else if (i % 2 != 0)
            {
                beersAll += inputArray[i];
            }
        }

        if (thievesAll >= n * 5)
        {
            Console.WriteLine("{0} thieves slapped.", n * 5);
            Console.WriteLine("{0} thieves escaped.", thievesAll - n * 5);
            Console.WriteLine("{0} packs, {1} bottles.", Math.Floor(beersAll / 6), beersAll % 6);
        }

        else if (thievesAll < n * 5)
        {
            Console.WriteLine("{0} thieves slapped.", thievesAll);
            Console.WriteLine("{0} thieves escaped.", 0);
            Console.WriteLine("{0} packs, {1} bottles.", Math.Floor(beersAll / 6), beersAll % 6);
        }
    }
}