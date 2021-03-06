﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ChessboardGame26April2015Morning
{
    static void Main()
    {
        int boardSize = int.Parse(Console.ReadLine());
        string inputString = Console.ReadLine();

        int cellsCount = boardSize * boardSize;
        if (cellsCount > inputString.Length)
        {
            string additionalCharacters = new string(' ', cellsCount - inputString.Length);
            inputString = inputString + additionalCharacters;
        }

        int blackTeamScore = 0;
        int whiteTeamScore = 0;

        for (int letter = 0; letter < cellsCount; letter++)
        {
            char currentChar = inputString[letter];

            if ((currentChar >= 'a' && currentChar <= 'z') ||
                (currentChar >= 'A' && currentChar <= 'Z') ||
                (currentChar >= '0' && currentChar <= '9'))
            {
                if (letter % 2 == 0)
                {
                    if (currentChar >= 'A' && currentChar <= 'Z')
                    {
                        whiteTeamScore += currentChar;
                    }
                    else
                    {
                        blackTeamScore += currentChar;
                    }
                }
                else if (letter % 2 != 0)
                {
                    if (currentChar >= 'A' && currentChar <= 'Z')
                    {
                        blackTeamScore += currentChar;
                    }
                    else
                    {
                        whiteTeamScore += currentChar;
                    }
                }
            }
        }
        if (blackTeamScore > whiteTeamScore)
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(blackTeamScore - whiteTeamScore);
        }
        if (whiteTeamScore > blackTeamScore)
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(whiteTeamScore - blackTeamScore);
        }
        else if (blackTeamScore == whiteTeamScore)
        {
            Console.WriteLine("Equal result: {0}", whiteTeamScore);
        }
    }
}