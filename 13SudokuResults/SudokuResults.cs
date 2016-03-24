using System;

class SudokuResults
{
    static void Main()
    {
        int gamesPlayed = 0;
        int totalSeconds = 0;

        string gameTime = Console.ReadLine();
        while (gameTime != "Quit")
        {
            gamesPlayed++;
            int min = int.Parse(gameTime.Substring(0, 2));
            int sec = int.Parse(gameTime.Substring(3, 2));
            totalSeconds += 60 * min + sec;
            gameTime = Console.ReadLine();
        }

        double average = (double)totalSeconds / gamesPlayed;

        if (average < 720)
        {
            Console.WriteLine("Gold Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", gamesPlayed, Math.Ceiling(average));
        }
        else if (average >= 720 && average <= 1440)
        {
            Console.WriteLine("Silver Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", gamesPlayed, Math.Ceiling(average));
        }
        else
        {
            Console.WriteLine("Bronze Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", gamesPlayed, Math.Ceiling(average));
        }
    }
}