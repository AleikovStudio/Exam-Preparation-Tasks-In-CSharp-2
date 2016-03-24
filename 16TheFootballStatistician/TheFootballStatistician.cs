using System;

class TheFootballStatistician
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());

        int arsenalPoints = 0;
        int chelseaPoints = 0;
        int evertonPoints = 0;
        int liverpoolPoints = 0;
        int manchesterCityPoints = 0;
        int manchesterUnitedPoints = 0;
        int southamptonPoints = 0;
        int tottenhamPoints = 0;
        decimal payment = 0;

        string data = Console.ReadLine();
        while (data != "End of the league.")
        {
            string[] array = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstTeam = array[0];
            string result = array[1];
            string secondTeam = array[2];

            int firstTeamPoints = 0;
            int secondTeamPoints = 0;

            if (result == "X")
            {
                firstTeamPoints += 1;
                secondTeamPoints += 1;
            }
            else if (result == "1")
            {
                firstTeamPoints += 3;
            }
            else if (result == "2")
            {
                secondTeamPoints += 3;
            }

            switch (firstTeam)
            {
                case "Arsenal": arsenalPoints += firstTeamPoints; break;
                case "Chelsea": chelseaPoints += firstTeamPoints; break;
                case "Everton": evertonPoints += firstTeamPoints; break;
                case "Liverpool": liverpoolPoints += firstTeamPoints; break;
                case "ManchesterCity": manchesterCityPoints += firstTeamPoints; break;
                case "ManchesterUnited": manchesterUnitedPoints += firstTeamPoints; break;
                case "Southampton": southamptonPoints += firstTeamPoints; break;
                case "Tottenham": tottenhamPoints += firstTeamPoints; break;
            }
            switch (secondTeam)
            {
                case "Arsenal": arsenalPoints += secondTeamPoints; break;
                case "Chelsea": chelseaPoints += secondTeamPoints; break;
                case "Everton": evertonPoints += secondTeamPoints; break;
                case "Liverpool": liverpoolPoints += secondTeamPoints; break;
                case "ManchesterCity": manchesterCityPoints += secondTeamPoints; break;
                case "ManchesterUnited": manchesterUnitedPoints += secondTeamPoints; break;
                case "Southampton": southamptonPoints += secondTeamPoints; break;
                case "Tottenham": tottenhamPoints += secondTeamPoints; break;
            }
            data = Console.ReadLine();
            for (int i = 0; i < array.Length; i++)
            {
                payment++;
            }
        }
        Console.WriteLine("{0:F2}lv.", payment * (n * 1.94m)/3);
        Console.WriteLine("Arsenal - {0} points.", arsenalPoints);
        Console.WriteLine("Chelsea - {0} points.", chelseaPoints);
        Console.WriteLine("Everton - {0} points.", evertonPoints);
        Console.WriteLine("Liverpool - {0} points.", liverpoolPoints);
        Console.WriteLine("Manchester City - {0} points.", manchesterCityPoints);
        Console.WriteLine("Manchester United - {0} points.", manchesterUnitedPoints);
        Console.WriteLine("Southampton - {0} points.", southamptonPoints);
        Console.WriteLine("Tottenham - {0} points.", tottenhamPoints);
    }
}