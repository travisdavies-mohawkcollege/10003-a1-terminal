using System;

class Program
{
    static void Main()
    {
        string travellerOneFirst = "Jeff";
        string travellerTwoFirst = "Sue";
        string travellerThreeFirst = "Joshua";
        string travellerOneLast = "Johnson";
        string travellerTwoLast = "Williams";
        string travellerThreeLast = "Joshin";
        int allow = 1;
        int deny = 2;
        int detain = 3;
        bool travellerOneDetain = false;
        bool travellerTwoDetain = true;
        bool travellerThreeDetain = false;
        bool travellerOneAllow = true;
        bool travellerTwoAllow = false;
        bool travellerThreeAllow = false;

        Console.WriteLine($"Welcome to your new job as a border guard agent employee.\nIt appears your information has not been filled into our system.\nPlease kindly insert your first name.");
        string playerFirst = Console.ReadLine();
        Console.WriteLine("And your last name.");
        string playerLast = Console.ReadLine();
        Console.WriteLine("Finally, please enter an employee ID number. It can be any number you desire.");
        int playerId = int.Parse(Console.ReadLine());  
        string playerName = $"{playerFirst} {playerLast}";
        Console.WriteLine($"Thank you, {playerName} with employee ID number {playerId}.");

    }
}
