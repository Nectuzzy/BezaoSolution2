Random num = new Random();
int rand = num.Next(1,50);
int i = 0;
string instruction = "Pick a random number between 1 and 50, while trying to guess the number the computer picked.";
int userInputStore = 0;

Console.Write("Enter your Username: ");
string userName = Console.ReadLine();
//Console.WriteLine($"{userName}");
Console.WriteLine($"{userName}, {instruction}");

while (i<=3)
{
    if (i == 3)
    {
        Console.WriteLine("Nice try, You lose. lol, loser, lmao!!!");
        break;
    }
    Console.Write("Enter a number: ");
    string userInput = Console.ReadLine();
    int test = Convert.ToInt16(userInput);
    
    if (test == rand)
    {
        Console.WriteLine($"{userName}, You win, rest... Lol!!!");
        break;
    } 

    else if (test == userInputStore)
    {
        Console.WriteLine($"{userName}, pick a number different from the one you picked before.");
        continue;
    }
    else if (test > rand)
    {
        Console.WriteLine("Number is too large. ");
        i++;
        userInputStore = test;
        continue;
    }
    else if (test < rand)
    {
        Console.WriteLine("Number is too small.");
        i++;
        userInputStore = test;
        continue;
    }  
}
