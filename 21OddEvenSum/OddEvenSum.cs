using System;


class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n * 2];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int sumEven = 0;
        int sumOdd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sumOdd += array[i];
            }
            else if (i % 2 == 0)
            {
                sumEven += array[i];
            }
        }
        
        int dif = Math.Abs(sumEven - sumOdd);
        if (sumEven == sumOdd)
        {
            Console.WriteLine("Yes, sum={0}", sumOdd);
        }

        else
        {
           Console.WriteLine("No, diff={0}", dif);
        }
    }
}
