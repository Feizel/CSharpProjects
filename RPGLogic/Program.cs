/*
You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int attack = dice.Next(1, 11);
    monster -= attack;
    System.Console.WriteLine($"The monster lost {attack} points and has {monster} health points");

    if (monster <= 0) continue;
    {
        attack = dice.Next(1, 11);
        hero -= attack;
        System.Console.WriteLine($"The hero lost {attack} points and has {hero} health points");
    }
    
} while ((monster > 0) && (hero > 0));

System.Console.WriteLine(hero > monster ? "\nHero wins!" : "\nMonster wins!");