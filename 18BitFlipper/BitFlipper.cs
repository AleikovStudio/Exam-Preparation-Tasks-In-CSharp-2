using System;
using System.Runtime.InteropServices;

class BitFlipper
{
    static void Main()
    {

        ulong num = ulong.Parse(Console.ReadLine());

        string numAsString = Convert.ToString((long)num, 2).PadLeft(64, '0');//WE MAKE THE NUMBER STRING -> SO WE CAN READ IT FROM LEFT TO RIGHT

        char[] array = numAsString.ToCharArray();//CONVERT THE STRING TO CHAR ARRAY TO CHANGE THE ELEMENTS AFTERWARDS -> WE CANNOT CHANGE STRINGS ELEMENTS

        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == array[i - 1] && array[i - 1] == array[i - 2])
            {
                if (array[i] == '0')
                {
                    array[i] = '1';
                    array[i - 1] = '1';
                    array[i - 2] = '1';
                }
                else
                {
                    array[i] = '0';
                    array[i - 1] = '0';
                    array[i - 2] = '0';
                }
                i += 2;
            }
        }
        //Console.WriteLine(array);//TO CHECK AS A BIT IN THE CHAR ARRAY
        Console.WriteLine(Convert.ToUInt64(new string(array), 2));

        //ulong num = ulong.Parse(Console.ReadLine());

        //for (int i = 61; i >= 0; i--)//USING 7 BECAUSE IT IS 111
        //{
        //    ulong threeeBits = (num >> i) & 7;
        //    if (threeeBits == 0 || threeeBits == 7)
        //    {
        //        num = num ^ (ulong)7 << i;
        //        i -= 2;
        //    }
        //}
        //Console.WriteLine(num);
    }
}