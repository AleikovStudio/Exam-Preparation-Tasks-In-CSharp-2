using System;

class Firefighters
{
    static void Main()
    {
        int numberOfFireFighters = int.Parse(Console.ReadLine());
        string userInput = Console.ReadLine();
        
        int currentKids = 0;
        int currentAdults = 0;
        int currentSeniors = 0;
        int currentFirefighters = numberOfFireFighters;
        int overallKidsSaved = 0;
        int overallAdultsSaved = 0;
        int overallSeniorsSaved = 0;

        while (userInput != "rain")
        {

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i]=='K')
                {
                    currentKids++;
                }
                if (userInput[i] =='A')
                {
                    currentAdults++;
                }
                if (userInput[i]=='S')
                {
                    currentSeniors++;
                }
            }

            if (numberOfFireFighters >= currentKids)
            {
                overallKidsSaved += currentKids;
                currentFirefighters -= currentKids;
                
                if (currentFirefighters >= currentAdults)
                {
                    overallAdultsSaved += currentAdults;
                    currentFirefighters -= currentAdults;
                    
                    if (currentFirefighters >= currentSeniors)
                    {
                        overallSeniorsSaved += currentSeniors;
                    }
                    else
                    {
                        overallSeniorsSaved += currentFirefighters;
                    }
                }
                else
                {
                    overallAdultsSaved += currentFirefighters;
                }
            }
            else
            {
                overallKidsSaved += currentFirefighters;
            }
            
            currentKids = 0;
            currentAdults = 0;
            currentSeniors = 0;
            currentFirefighters = numberOfFireFighters;

            userInput = Console.ReadLine();
        }
        
        Console.WriteLine("Kids: {0}", overallKidsSaved);
        Console.WriteLine("Adults: {0}", overallAdultsSaved);
        Console.WriteLine("Seniors: {0}", overallSeniorsSaved);
    }
}