using System;

class Cinema
{
    static void Main()
    {
        string data = Console.ReadLine();
        decimal row = decimal.Parse(Console.ReadLine());
        decimal col = decimal.Parse(Console.ReadLine());

        decimal income;
        switch (data)
        {
            case "Premiere":
                income = (row * col) * 12.00m;
                Console.WriteLine("{0:f2} leva", income);
                break;
            case "Normal":
                income = (row * col) * 7.5m;
                Console.WriteLine("{0:f2} leva", income);
                break;
            case "Discount":
                income = (row * col) * 5.00m;
                Console.WriteLine("{0:f2} leva", income);
                break;
        }
    }
}