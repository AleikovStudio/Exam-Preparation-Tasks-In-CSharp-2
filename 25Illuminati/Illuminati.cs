using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Illuminati
{
    static void Main()
    {
        string data = Console.ReadLine();
        char[] dataAr = data.ToCharArray();

        decimal sum = 0;
        decimal vows = 0;

        for (int i = 0; i < dataAr.Length; i++)
        {
            if (dataAr[i] == 'A' || dataAr[i] == 'a')
            {
                sum += 65;
                vows++;
            }
            if (dataAr[i] == 'E' || dataAr[i] == 'e')
            {
                sum += 69;
                vows++;
            }
            if (dataAr[i] == 'I' || dataAr[i] == 'i')
            {
                sum += 73;
                vows++;
            }
            if (dataAr[i] == 'O' || dataAr[i] == 'o')
            {
                sum += 79;
                vows++;
            }
            if (dataAr[i] == 'U' || dataAr[i] == 'u')
            {
                sum += 85;
                vows++;
            }
        }
        Console.WriteLine(vows);
        Console.WriteLine(sum);
    }
}