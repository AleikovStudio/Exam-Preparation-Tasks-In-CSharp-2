using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LightTheTorches
{
    static void Main()
    {
        int numOfRooms = int.Parse(Console.ReadLine());
        string pattern = Console.ReadLine();
        char[] basement = new char[numOfRooms];

        //int patternIndex = 0;
        for (int i = 0; i < numOfRooms; i++)
        {
            //if (patternIndex== pattern.Length)
            //{
            //    patternIndex = 0;
            //}
            int patternIndex = i% pattern.Length;
            basement[i] = pattern[patternIndex];
        }
        string command = Console.ReadLine();
        while (command != "END")
        {


            command = Console.ReadLine();
        }
    }
}