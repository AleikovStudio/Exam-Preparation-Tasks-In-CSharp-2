using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BohemchoTheBadGhost
{
    static void Main()
    {
        string floorStr = Console.ReadLine();//IT IS STRING BECAUSE OF THE LINE: "Stop, God damn it"
        
        while (floorStr != "Stop, God damn it")
        {
            uint floor = uint.Parse(floorStr);//NOW WE CAN CONVERT THE INPUT TO INT - NO WORRIES ABOUT: "Stop, God damn it"
            string[] app = Console.ReadLine().Split(' ');//THE ARRAY IS STRING BECAUSE OF THE SPLIT OPTION
            int[] app2 = new int[app.Length];//ARRAY OF INT MADE BY THE ABOVE ARRAY OF STRINGS
            for (int i = 0; i < app.Length; i++)
            {
                app2[i] = int.Parse(app[i]);
            }

            for (int i = 0; i < app2.Length; i++)
            {
                uint mask = 1;
                mask = mask << app2[i];
                mask = floor & mask;

            }


            floorStr = Console.ReadLine();
        }
    }

}