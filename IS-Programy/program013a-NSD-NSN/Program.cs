string again = "a";
while (again == "a")
{
   
    Console.Clear();

    razitko();

    ulong a = nactiCislo("Zadejte první číslo a: ");
    ulong b = nactiCislo("Zadejte druhé číslo b: ");

    
    static void razitko()
    {
        Console.WriteLine("***********************************");
        Console.WriteLine("***** Výpočet čisla NSN a NSD *****");
        Console.WriteLine("***********************************");
        Console.WriteLine("********** Patrik Hečko ***********");
        Console.WriteLine("***********************************");
    }

    static ulong nactiCislo( string zprava )
    {
        Console.Write(zprava);
        ulong cislo;

        while (!ulong.TryParse(Console.ReadLine(), out cislo))
        {
            Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
        }
        
        return cislo;
    }
















    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
