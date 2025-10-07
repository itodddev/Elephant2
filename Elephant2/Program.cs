using ElephantSwap;

Elephant lloyd = new Elephant { Name = "Lloyd", EarSize = 40 };
Elephant lucinda = new Elephant { Name = "Lucinda", EarSize = 33 };


Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

while (true)
{
    int value = Console.Read();
    if (value == '1')
    {
        Console.WriteLine("You pressed 1");
        lloyd.WhoAmI();
    }
    else if (value == '2')
    {
        Console.WriteLine("You pressed 1");
        lucinda.WhoAmI();
    }
    else if (value == '3')
    {
        Console.WriteLine("You pressed 3");
        Console.WriteLine("References have been swapped");
        Elephant holder;
        holder = lloyd;
        lloyd = lucinda;
        lucinda = holder;
    }
}
