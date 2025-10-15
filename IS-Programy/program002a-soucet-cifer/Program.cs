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
    int numberbackup = number; // záloha původního čísla pro výpis
    int digit;

    if (number < 0) // pokud je číslo záporné, uděláme z něj kladné
    {
        number = -number;
    }

    while (number >= 10)
    {
        digit = number % 10; // získání poslední číslice
        suma += digit; // přičtení číslice k součtu
        number /= 10; // odstranění poslední číslice
    }

    Console.WriteLine($"Ciferný součet číslic {numberbackup} je {suma}.");

    //Opakovani programu
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}