using System;

class ProspectInHospitality
{
    static void Main()
    {
        decimal builders = decimal.Parse(Console.ReadLine());//The amount of builders needed.
        decimal receptionists = decimal.Parse(Console.ReadLine());//The amount of receptionists needed.
        decimal chambermaids = decimal.Parse(Console.ReadLine());//The amount of chambermaids needed.
        decimal technicians = decimal.Parse(Console.ReadLine());//The amount of technicians needed.
        decimal others = decimal.Parse(Console.ReadLine());//The amount of other staff members needed.
        decimal nikiSalaryUs = decimal.Parse(Console.ReadLine());//Niki’s salary in USD.
        decimal usRateToBg = decimal.Parse(Console.ReadLine());//USA’s currency rate at the moment.
        decimal mySalary = decimal.Parse(Console.ReadLine());//Your salary.
        decimal budget = decimal.Parse(Console.ReadLine());//The overall budget.

        decimal allSalaries = 0;
        allSalaries += builders * 1500.04m;
        allSalaries += receptionists * 2102.10m;
        allSalaries += chambermaids * 1465.46m;
        allSalaries += technicians * 2053.33m;
        allSalaries += others * 3010.98m;
        allSalaries += nikiSalaryUs * usRateToBg;
        allSalaries += mySalary;

        if (budget >= allSalaries)
        {
            Console.WriteLine("The amount is: {0:f2} lv.", allSalaries);
            Console.WriteLine("YES \\ Left: {0:f2} lv.", budget - allSalaries);
        }
        else if (budget < allSalaries)
        {
            Console.WriteLine("The amount is: {0:f2} lv.", allSalaries);
            Console.WriteLine("NO \\ Need more: {0:f2} lv.", allSalaries - budget);
        }
    }
}