//Jessie Lamzon
//10/18/22
//GitHubChallenge - Redo mini Challenges
//Mad Lib - data validation and play again


Console.Clear();

string playAgain = "yes";
while (playAgain != "no")
{
    Console.WriteLine("Let's play a game of Mad Libs!");
    Console.WriteLine("Rules: type in a word based on the preference needed, and it will turn into a magical story");

    //user input for game
    Console.WriteLine("Please enter a Celebrity name");
    string celeb = Console.ReadLine();

    Console.WriteLine("exotic animal");
    string animal = Console.ReadLine();

    Console.WriteLine("person's name");
    string pName = Console.ReadLine();

    Console.WriteLine("profession");
    string profession = Console.ReadLine();

    Console.WriteLine("name a us state or country");
    string from = Console.ReadLine();

    Console.WriteLine("body part");
    string bodyPart = Console.ReadLine();

    Console.WriteLine("plant(plural)");
    string plant = Console.ReadLine();

    Console.WriteLine("action word");
    string action = Console.ReadLine();

    Console.WriteLine("Okay, here it goes!");

    Console.WriteLine("");
    Console.WriteLine($"I woke up this morning and saw {celeb}. I said hey! What are you doing with my {animal}!");
    Console.WriteLine($"{celeb} looked at me and said who are you?! I said I'm {pName} and im a {profession} from {from}.");
    Console.WriteLine($"{celeb} touched my {bodyPart} and yelled, You are in my house!");
    Console.WriteLine($"Realizing i was in {celeb}'s house, I {action} out of bed and grabbed my {plant}.");
    Console.WriteLine("I then woke up.....it was just a silly dream.");
    Console.WriteLine("");

    Console.WriteLine("Thanks for playing!\n");

    //this will loop if user chooses to play again or end the game
    Console.WriteLine("Press any key to play again or Type no.....");
    playAgain = Console.ReadLine().ToLower();
}

Console.WriteLine("Thanks for playing!");