using System;
using System.ComponentModel.Design;

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
        bool travellerOneAllow = true;
        bool travellerTwoAllow = false;
        bool travellerThreeAllow = false;
        bool travellerOneWelcome = true;
        bool travellerTwoWelcome = true;
        bool travellerThreeWelcome = true;
        int score = 0;

        Console.WriteLine($"Welcome to your new job as a border guard agent employee.\nIt appears your information has not been filled into our system.\nPlease kindly insert your first name.");
        string playerFirst = Console.ReadLine();
        Console.WriteLine("And your last name.");
        string playerLast = Console.ReadLine();
        Console.WriteLine("Finally, please enter an employee ID number. It can be any number you desire.");
        int playerId = int.Parse(Console.ReadLine());
        string playerName = $"{playerFirst} {playerLast}";
        Console.WriteLine($"Thank you, {playerName} with employee ID number {playerId}.");
        Console.WriteLine("We will now go over the requirements for travellers entering the country today.\n1. No entry to those over 6'2.\n2. Deny anyone who tells you incorrect information.\n3. We are expecting a man with the initials JJ. Make sure he gets in.");
        Console.WriteLine($"Letting in the first traveller, good luck officer #{playerId}, stay vigilant!");
        Console.WriteLine($"Greetings, officer! The name is {travellerOneFirst}. Here is my ID card.");
        Console.WriteLine($"Height : 5'9\tWeight: 190\tMarital Status: Never Married\nFull Name: {travellerOneFirst} {travellerOneLast}");
        Console.WriteLine("Is this traveller allowed into the country? Enter 1 to allow, 2 to deny.\nUnrecognized input will result in traveller being denied.");
        int answer = int.Parse(Console.ReadLine());
        if (answer == allow)
        {
            travellerOneWelcome = true;
        }
        else
        {
            travellerOneWelcome = false;
        }


        Console.WriteLine("Thank you, verifying your answer with a senior officer.");
        if (travellerOneWelcome == travellerOneAllow)
        {
            Console.WriteLine("You were correct, congratulations officer. You have gained 250 points.");
            score = score + 250;
        }
        else
        {
            Console.WriteLine("Incorrect. Be more careful with future decisions. You have lost 250 points.");
            score = score - 250;
        }
        Console.WriteLine("The second traveller will now be let in.");
        Console.WriteLine($"H-h-hello officer.. I am {travellerTwoFirst} {travellerOneLast}. Well, soon I mean, I am getting married to the man who walked through here last!\n Here is my ID card.");
        Console.WriteLine($"Height : 5'5\tWeight: 160\tMarital Status: Never Married\nFull Name: {travellerTwoFirst} {travellerTwoLast}");
        Console.WriteLine("Is this traveller allowed into the country? Enter 1 to allow, 2 to deny.\nUnrecognized input will result in traveller being denied.");
        answer = int.Parse(Console.ReadLine());
        if (answer == allow)
        {
            travellerTwoWelcome = true;
        }
        else
        {
            travellerTwoWelcome = false;
        }


        Console.WriteLine("Thank you, verifying your answer with a senior officer.");
        if (travellerTwoWelcome == travellerTwoAllow)
        {
            Console.WriteLine("You were correct, congratulations officer. You have gained 250 points.");
            score = score + 250;
        }
        else
        {
            Console.WriteLine("Incorrect. Be more careful with future decisions. You have lost 250 points.");
            score = score - 250;
        }
            Console.WriteLine("The third and final traveller for this session will now be let it.");
            Console.WriteLine($"Hiya, sir! I'm {travellerThreeFirst} {travellerThreeLast}. I saved all summer to come visit this country, I cannot wait to see all it has to offers! Here's my ID card.");
            Console.WriteLine($"Height : 6'6\tWeight: 220\tMarital Status: Common Law\nFull Name: {travellerThreeFirst} {travellerThreeLast}");
            Console.WriteLine("Is this traveller allowed into the country? Enter 1 to allow, 2 to deny.\nUnrecognized input will result in traveller being denied.");
            answer = int.Parse(Console.ReadLine());
            if (answer == allow)
            {
                travellerThreeWelcome = true;
            }
            else
            {
                travellerThreeWelcome = false;
            }


            Console.WriteLine("Thank you, verifying your answer with a senior officer.");
            if (travellerThreeWelcome == travellerThreeAllow)
            {
                Console.WriteLine("You were correct, congratulations officer. You have gained 250 points.");
                score = score + 250;
            }
            else
            {
                Console.WriteLine("Incorrect. Be more careful with future decisions. You have lost 250 points.");
                score = score - 250;
            }
            Console.WriteLine($"That completes this training session. Thank you employee #{playerId}, you will now be evaulated. Your final score was {score}");
            if (score <= 250)
            {
                Console.WriteLine("Due to your performance, you are fired from this job and blacklisted from future attempts. Thank you, and never come back.");
            }
            else if (score <= 750)
            {
                Console.WriteLine("Congratualations! You are hired for your exceptional performance. You start tomorrow, do not be late!");
            }
            else

                Console.WriteLine("You are adequate. Please attempt to improve slightly and we will consider hiring you. Good Luck!");
        }
    }



        



