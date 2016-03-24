using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WaveBits
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        string n2 = Convert.ToString((long)n, 2).PadLeft(32, '0');
        char[] n3 = n2.ToCharArray();
        Console.WriteLine(n3);
        List<char> n4 = new List<char>();
        
        for (int i = 0; i < n3.Length; i++)
        {
            n4.Add(n3[i]);
        }

        n4.Reverse();
        for (int i = 2; i < n4.Count; i++)
        {
            if (n4[i]=='1' && n4[i-1]=='0' && n4[i-2]=='1')
            {
                n4.Remove(n4[i]);
                n4.Remove(n4[i-1]);
                n4.Remove(n4[i-2]);
            }
            i += 2;
        }
        n4.Reverse();
        foreach (var VARIABLE in n4)
        {
            Console.Write(VARIABLE);
        }

        //Array.Reverse(n3);

        //for (int i = 0; i < n3.Length; i++)
        //{
        //    if (n3[i] == n3[i + 1] && n3[i + 1] == n3[i + 2])
        //    {
        //        Array.ForEach();
        //    }
        //}

    }
}