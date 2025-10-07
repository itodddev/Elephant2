using ElephantSwap;

Elephant lloyd = new Elephant { Name = "Lloyd", EarSize = 40 };
Elephant lucinda = new Elephant { Name = "Lucinda", EarSize = 33 };


Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

while (true)
{
    char input = Console.ReadKey(true).KeyChar;
    if (input == '1')
    {
        Console.WriteLine("You pressed 1");
        lloyd.WhoAmI();
    }
    else if (input == '2')
    {
        Console.WriteLine("You pressed 2");
        lucinda.WhoAmI();
    }
    else if (input == '3')
    {
        Console.WriteLine("You pressed 3");
       
        Elephant holder;
        holder = lloyd;
        lloyd = lucinda;
        lucinda = holder;

        Console.WriteLine("References have been swapped");
    }
    else
    {
        return;
    }

    Console.WriteLine();
}
