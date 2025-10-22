ConsoleColor color = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("#############################");
    Console.WriteLine("##### Řazení dvou čísel #####");
    Console.WriteLine("#############################");
    Console.WriteLine("#####   Patrik Hečko    #####");
    Console.WriteLine("#############################");
    Console.WriteLine("");

    Console.Write("Zadejte číslo - hodnota A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte znovu hodnotu A: ");
    }

    Console.Write("Zadejte číslo - hodnota B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte znovu hodnotu B: ");
    }

    // pokud je číslo záporné, uděláme z něj kladné
    if (a < 0)
        a = -a;

    if (b < 0)
        b = -b;
    //###########################################################################################
    // Řazení čísel

    int pom;
    if (a > b)
    {
        pom = a;
        a = b;
        b = pom;
    }
    Console.WriteLine($"Seřazená čísla jsou: {a}, {b}");
    
    // Opakování programu
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}