string again = "a";
while (again == "a")
{
   
    Console.Clear();

    razitko();

    ulong a = nactiCislo("Zadejte první číslo a: ");
    ulong b = nactiCislo("Zadejte druhé číslo b: ");

    ulong nsd = vypocitatNSD(a, b);
    ulong nsn = vypocitanitNSN(a, b, nsd);

    vypisvysledku(a, b, nsd, nsn);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}

    static void razitko()
    {
        Console.WriteLine("***********************************");
        Console.WriteLine("***** Výpočet čisla NSN a NSD *****");
        Console.WriteLine("***********************************");
        Console.WriteLine("********** Patrik Hečko ***********");
        Console.WriteLine("***********************************");
    }

    static void vypisvysledku(ulong a, ulong b, ulong nsd, ulong nsn)
    {
        Console.WriteLine();
        Console.WriteLine("***********************************");
        Console.WriteLine("************* Výsledek ************");
        Console.WriteLine("***********************************");
        Console.WriteLine();
        Console.WriteLine("***********************************");
        Console.WriteLine($"Největší společný dělitel (NSD) čísel {a} a {b} je: {nsd}");
        Console.WriteLine();
        Console.WriteLine("***********************************");
        Console.WriteLine($"Nejmenší společný násobek (NSN) čísel {a} a {b} je: {nsn}");
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

    static ulong vypocitatNSD(ulong a, ulong b)
    {
        while (a != b)
        {
           if (a > b)
           {
               a = a - b;
           }
           else
           {
               b = b - a;
           }
        }
        return a;
    }

    static ulong vypocitanitNSN(ulong a, ulong b, ulong nsd)
    {
        ulong nsn = (a * b) / nsd;
        return nsn;
    }
