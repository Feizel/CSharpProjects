
System.Console.WriteLine("Generating 5 Random Numbers");
DisplayRandomNumbers();

void DisplayRandomNumbers() 
{
    Random random = new Random();

    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    System.Console.WriteLine();
}