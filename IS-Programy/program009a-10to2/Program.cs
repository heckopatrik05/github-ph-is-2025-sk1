string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**************************************");
    Console.WriteLine("***** Převod soustav z 1O. do 2. *****");
    Console.WriteLine("**************************************");
    Console.WriteLine("************ Patrik Hečko ************");
    Console.WriteLine("**************************************");
    Console.WriteLine();

    Console.Write("Zadejte první číslo řady (celé číslo): ");
    uint first;

    while (!uint.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    uint backupnumber10 = first;
    uint zbyvajicihodnota;

    uint[] myarray = new uint[32];

    uint i;
    for (int i = 0; first > 0; i++)
    {
        zbyvajicihodnota = first % 2;
        first = (first-zbyvajicihodnota) / 2;
        myarray [i] = zbyvajicihodnota;

        Console.WriteLine("Zbytek po dělení 2: " + zbyvajicihodnota);
        Console.WriteLine("Nová hodnota čísla: " + first);
    }

    Console.WriteLine();
    for (uint j=i-1 ; j>=0; j--)
    {
        Console.Write(myarray[j]);
    }

    // Převod z desítkové do dvojkové soustavy pomocí vestavěné funkce
    string binary = Convert.ToString(first, 2);
    Console.WriteLine("Binární reprezentace: " + binary);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}
