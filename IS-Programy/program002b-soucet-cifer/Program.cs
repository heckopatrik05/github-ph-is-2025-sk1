ConsoleColor color = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("##########################################");
    Console.WriteLine("##### Ciferný součet číslic a součin #####");
    Console.WriteLine("##########################################");
    Console.WriteLine("#####           Patrik Hečko         #####");
    Console.WriteLine("##########################################");
    Console.WriteLine("");

    Console.Write("Zadejte číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte číslo znovu: ");
    }

    int suma = 0;
    int numberbackup = number; // záloha původního čísla

    // pokud je číslo záporné, uděláme z něj kladné
    if (number < 0)
        number = -number;


    //###########################################################################################

    //Tady si to jednoduse prevedeme na string a projdeme kazdou cifru

    // převod čísla na řetězec a následné zpracování každé číslice
    string numberStr = number.ToString();
    foreach (char c in numberStr)
    {
        suma += c - '0'; // převede znak číslice na číselnou hodnotu
    }

    Console.WriteLine($"Ciferný součet číslic {numberbackup} je {suma}.");

    // Opakování programu
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}