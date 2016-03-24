using System;

class TakeThePlaneDown
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int fighterX = int.Parse(Console.ReadLine());
            int fighterY = int.Parse(Console.ReadLine());
            int calcX = fighterX - x;
            int calxY = fighterY - y;
            int dist = calxY * calxY + calcX * calcX;

            if (r * r >= dist)
            {
                Console.WriteLine("You destroyed a plane at [{0},{1}]", fighterX, fighterY);
            }
        }
    }
}