using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ShuffleBits
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint n2 = uint.Parse(Console.ReadLine());

        string nStr = Convert.ToString((uint)n, 2).PadLeft(32, '0');
        string n2Str = Convert.ToString((uint)n2, 2).PadLeft(32, '0');

        char[] nchAr = nStr.ToCharArray();
        char[] n2chAr = n2Str.ToCharArray();

        List<char> nList = new List<char>();
        List<char> n2List = new List<char>();

        for (int i = 0; i < nchAr.Length; i++)
        {
            nList.Add(nchAr[i]);
        }

        for (int i = 0; i < n2chAr.Length; i++)
        {
            n2List.Add(n2chAr[i]);
        }
        foreach (var VARIABLE in nList)
        {
            Console.Write(VARIABLE);
        }
        Console.WriteLine();
        foreach (var VARIABLE in n2List)
        {
            Console.Write(VARIABLE);
        }
        Console.WriteLine("govno");

        List<char> novo = new List<char>();

        for (int i = 0; i < nList.Count; i++)
        {
            if (i % 2 != 0)
            {
                novo.Add(nList[i]);
            }
        }

        for (int i = 0; i < n2List.Count; i++)
        {
            if (i % 2 == 0)
            {
                novo.Add(n2List[i]);
            }
        }

        foreach (var VARIABLE in novo)
        {
            Console.Write(VARIABLE);
        }

    }
}