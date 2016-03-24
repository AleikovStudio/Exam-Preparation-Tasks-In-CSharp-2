using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecryptTheMessages26April2015Morning
{
    static void Main()
    {
        string inputString = string.Empty;//po default pravim stringa da e prazen
        List<string> msges = new List<string>();//sazdavame nov List, zashtoto ne znaem kolko shte sa elementite vatre

        do
        {
          inputString = Console.ReadLine();//tuk potrebitelyat kazva "start"
        } while (inputString.ToUpper() != "START");

        inputString = Console.ReadLine();//tuk veche potrebitelyat vavejda samiya string

        while (inputString.ToUpper() != "END")//dokato potrebitelyat ne vavede "End" (nakraya) - se izpalnyava uslovieto v while loop-a
        {
            if (inputString != "")//proverka - ako stringat NE E prazen
            {
                string decryptedMsg = "";
                for (int symbol = 0; symbol < inputString.Length; symbol++)//vav for loop-a smyatame spored daljinata na inputString - sbora na simvolite 
                {
                    if ((inputString[symbol] >= 'A') && (inputString[symbol] <= 'Z') ||
                        (inputString[symbol] >= 'a') && (inputString[symbol] <= 'z'))//proveryavame dali vavedenite danni sa v bukvite
                    {
                        if ((inputString[symbol] >= 'A') && (inputString[symbol] <= 'M') ||
                            (inputString[symbol] >= 'a') && (inputString[symbol] <= 'm'))
                        {
                            decryptedMsg += (char)(inputString[symbol] + 13);//ot 'A' do 'M' - ima 13 simvola (ot 65 do 77); 'A' stava 'N' kato mu se dobavi 13
                        }
                        else
                        {
                            decryptedMsg += (char)(inputString[symbol] - 13);//ot 'M' do 'Z'
                        }
                    }
                    else
                    {
                        switch (inputString[symbol])//proveryavame za specialnite simvoli + konvertirame simvolite - kato vseki zamesten takav - ima cifrova stoinost v ASCII table
                        {
                            case '+': decryptedMsg += ' ';
                                break;
                            case '%': decryptedMsg += ',';
                                break;
                            case '&': decryptedMsg += '.';
                                break;
                            case '#': decryptedMsg += '?';
                                break;
                            case '$': decryptedMsg += '!';
                                break;
                            default: decryptedMsg += inputString[symbol];//tazi default proverka e za cifrite - t.e. ako ne sa bukvi ili spec. simvoli - to izpalnyavame uslovieto za cifrite
                                break;
                        }
                    }
                }
                char[] reversedArray = decryptedMsg.ToCharArray();
                Array.Reverse(reversedArray);//obrashtame naobratno stringa
                decryptedMsg = new string(reversedArray);

                msges.Add(decryptedMsg);//dobavyame stringa v Lista - List<string> msges = new List<string>();
            }
            inputString = Console.ReadLine();//tuk potrebitelyat kazva "end"
        }
        if (msges.Count != 0)//broyat na elementite v spisaka e razlichen ot 0
        {
            Console.WriteLine("Total number of messages: {0}", msges.Count);
            foreach (var item in msges)
            {
                Console.WriteLine(item);                
            }
        }
        else//v sluchai che nyama saobshtenie
        {
            Console.WriteLine("No message received.");
        }
    }
}