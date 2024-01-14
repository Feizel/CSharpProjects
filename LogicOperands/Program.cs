// See https://aka.ms/new-console-template for more information
Console.WriteLine("DICE GAME");
Console.WriteLine("=========");

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"\nDice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if (total > 14)
{
    System.Console.WriteLine("You win!");
}

if (total < 15)
{
    System.Console.WriteLine("Sorry, you lose.");
}


