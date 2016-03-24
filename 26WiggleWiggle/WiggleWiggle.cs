using System;
using System.Text;

class WiggleWiggle
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < input.Length; i += 2)//STAPKATA E i+=2
        {
            long n1 = long.Parse(input[i]);
            long n2 = long.Parse(input[i + 1]);

            for (int j = 0; j < 63; j += 2)
            {
                long currBit1 = (n1 >> j) & 1L;//1-e s LONG v kraya
                long currBit2 = (n2 >> j) & 1L;//1-e s LONG v kraya

                if (currBit1 != currBit2)
                {
                    if (currBit1 == 1)
                    {
                        n1 ^= 1L << j;
                        n2 |= currBit1 << j;
                    }
                    else
                    {
                        n2 ^= 1L << j;
                        n1 |= currBit2 << j;
                    }
                }
            }
            //Console.WriteLine(n1);//36518969070
            //Console.WriteLine(n2);//2621284317
            n1 = n1 ^ long.MaxValue;//OBRASHTANE NA BITOVETE
            n2 = n2 ^ long.MaxValue;

            string n1Bin = Convert.ToString(n1, 2).PadLeft(63, '0');
            string n2Bin = Convert.ToString(n2, 2).PadLeft(63, '0');


            Console.WriteLine("{0} {1}", n1, n1Bin);
            Console.WriteLine("{0} {1}", n2, n2Bin);


            //string[] input = Console.ReadLine().Split();//STRINGOSVANO RESHENIE - SAS STRING BUILDER - IMA MNOGO FUNKCII!!!
            ////for (int i = input.Length-1; i >=0; i--)//OBRATEN FOR CIKAL
            //for (int i = 0; i < input.Length; i += 2)
            //{
            //    long n1 = long.Parse(input[i]);
            //    long n2 = long.Parse(input[i + 1]);
            //    string n1Bin = Convert.ToString(n1, 2).PadLeft(64, '0');
            //    string n2Bin = Convert.ToString(n2, 2).PadLeft(64, '0');
            //    StringBuilder sb1 = new StringBuilder(n1Bin);
            //    StringBuilder sb2 = new StringBuilder(n2Bin);

            //    for (int j = 0; j < 63; j += 2)
            //    {
            //        if (sb1[j] != sb2[j])
            //        {
            //            char c = sb1[j];
            //            sb1[j] = sb2[j];
            //            sb2[j] = c;
            //        }
            //    }

            //    sb1.Replace('1', 'r');
            //    sb1.Replace('0', '1');
            //    sb1.Replace('r', '0');
            //    sb1.Replace('1', 'r');
            //    sb1.Replace('0', '1');
            //    sb1.Replace('r', '0');

            //    n1 = Convert.ToInt64(sb1.ToString(), 2);
            //    n2 = Convert.ToInt64(sb2.ToString(), 2);

            //    Console.WriteLine("{0} {1}", n1, sb1);
            //    Console.WriteLine("{0} {1}", n2, sb2);
            //

        }
    }
}