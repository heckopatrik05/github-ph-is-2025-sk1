﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** Kombinovaná úloha *******************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*************** Patrik Hečko ***************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    // Deklarace pole
    int[] numbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        numbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", numbs[i]);
    }

    // -----------------------------------------
    // Hledání max a min + všechny jejich pozice
    // -----------------------------------------
    int max = numbs[0];
    int min = numbs[0];
    for (int i = 1; i < n; i++)
    {
        if (numbs[i] > max)
            max = numbs[i];

        if (numbs[i] < min)
            min = numbs[i]; 
    }

    Console.WriteLine();
    Console.WriteLine("---------------------------------------");
    Console.Write($"Maximum je {max}; jeho pozice: ");
    for (int i = 0; i < n; i++) {
        if (numbs[i] == max)
            Console.Write($"{i}; ");
    }
    Console.WriteLine();
    Console.WriteLine("---------------------------------------");
    Console.Write($"Minimum je {min}; jeho pozice: ");
    for (int i = 0; i < n; i++) {
        if (numbs[i] == min)
            Console.Write($"{i}; ");
    }

    // -----------------------------------------
    // Seřazení pole - Shaker sort neumím - použiji alespoň bubble sort
    // -----------------------------------------
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            
            if (numbs[j] < numbs[j + 1])
            {
                int tmp = numbs[j + 1];
                numbs[j + 1] = numbs[j];
                numbs[j] = tmp;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine("Seřazená čísla pomocí Bubble sortu: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", numbs[i]);
    }

    // --- MOŽNOST B: SELECTION SORT (Sestupně) ---
    for (int i = 0; i < n - 1; i++)
    {
        int maxIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            // Hledáme největší prvek ve zbytku pole
            if (numbs[j] > numbs[maxIndex]) // > hledáme maximum
            {
                maxIndex = j;
            }
        }
        // Prohození
        int tmp = numbs[maxIndex];
        numbs[maxIndex] = numbs[i];
        numbs[i] = tmp;
    }

    // --- MOŽNOST C: INSERTION SORT (Sestupně) ---
    // (Tento je momentálně aktivní - pokud chceš jiný, odkomentuj ho nahoře a zakomentuj tento)
    for (int i = 1; i < n; i++)
    {
        int key = numbs[i];
        int j = i - 1;

        // Posouváme prvky, které jsou menší než key, doprava
        while (j >= 0 && numbs[j] < key) // < key znamená sestupně
        {
            numbs[j + 1] = numbs[j];
            j--;
        }
        numbs[j + 1] = key;
    }

    // ------------------------------------
    // Druhé, třetí, čtvrté největší číslo - řeší správně duplicity
    // ------------------------------------ 
    int uniqueCount = 0;
    int lastValue = int.MinValue;
    int second = 0, third = 0, fourth = 0;
    for (int i = 0; i < n; i++) {
        if (numbs[i] != lastValue)
        {
            uniqueCount++;
            lastValue = numbs[i];

            if (uniqueCount == 2) 
                second = numbs[i];
            if (uniqueCount == 3)
                third = numbs[i];
            if (uniqueCount == 4)
                fourth = numbs[i];
        }
    }

    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine("Druhé největší číslo: " + second);
    Console.WriteLine("Třetí největší číslo: " + third);
    Console.WriteLine("Čtvrté největší číslo: " + fourth);

    // ------------------------------------
    // Medián
    // ------------------------------------
    int median;
    if (n % 2 == 1)
        median = numbs[n / 2];
    else
        median = (numbs[n / 2 - 1] + numbs[n / 2]) / 2;
    
    Console.WriteLine();
    Console.WriteLine("=================================="); 
    Console.WriteLine($"Medián: {median}");

    // =========================================================================
    // NOVÉ: Průměr (celočíselný)
    // =========================================================================
    long soucet = 0;
    for (int i = 0; i < n; i++)
    {
        soucet += numbs[i];
    }
    
    int prumer = (int)(soucet / n);
    long zbytek = soucet % n; // Výpočet zbytku po dělení

    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine($"Průměr: {prumer}, zbytek: {zbytek}");

    // ------------------------------------
    // Čtvrté největší číslo převedené do binární soustavy
    // ------------------------------------
    string bin = "";
    int x = fourth;
    if (x == 0) bin = "0";
    while (x > 0)
    {
        bin = (x % 2) + bin;
        x /= 2; // to samé jako x = x / 2;
    }

    Console.WriteLine();
    Console.WriteLine("=================================="); 
    Console.WriteLine($"Čtvrté největší číslo v binární soustavě: {fourth}(2) = {bin}");

    // =========================================================================
    // NOVÉ: Výpočet NSD a NSN pro 2. a 4. největší číslo (BEZ FUNKCÍ)
    // =========================================================================
    Console.WriteLine();
    Console.WriteLine("---------------------------------------");
    // Ošetření: Musíme mít nalezená čísla a nesmí být 0
    if (second > 0 && fourth > 0)
    {
        // 1. Příprava proměnných (uložíme si originály pro výpočet NSN)
        ulong valA = (ulong)second;
        ulong valB = (ulong)fourth;
        ulong tempA = valA;
        ulong tempB = valB;
        while (tempA != tempB)
        {
            if (tempA > tempB)
            {
                tempA = tempA - tempB;
            }
            else
            {
                tempB = tempB - tempA;
            }
        }
        ulong nsd = tempA; // Výsledek NSD
        // 3. Výpočet NSN (vzoreček: (a * b) / NSD)
        ulong nsn = (valA * valB) / nsd;
        Console.WriteLine($"NSD čísel {second} a {fourth} je: {nsd}");
        Console.WriteLine($"NSN čísel {second} a {fourth} je: {nsn}");
    }
    else
    {
        Console.WriteLine("NSD a NSN nelze vypočítat (nedostatek unikátních čísel nebo nula).");
    }
    // =========================================================================


    // ------------------------------------
    // Obrazec: výška podle mediánu a šířka podle třetího největšího čísla
    // ------------------------------------
    Console.WriteLine();
    Console.WriteLine("=================================="); 
    int height = median;
    int width = third;
    Console.WriteLine($"Obrazec jehož výška je {height} a šířka je {width}");
    Console.WriteLine();
    int part = height / 3;
    // rozhodnutí podle sudé / liché šířky
    int smallWidth;
    int indent;
    // počet potřebných mezer pro první a třetí část obrazce
    if (width % 2 == 0)
    {
        smallWidth = 2;
        indent = (width - 2) / 2;
    }
    else
    {
        smallWidth = 3;
        indent = (width - 3) / 2;
    }
    for (int i = 0; i < height; i++)
    {
        // horní část
        if (i < part)
        {
            for (int s = 0; s < indent; s++)
                Console.Write("  ");

            for (int j = 0; j < smallWidth; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
        // prostřední část
        else if (i < height - part)
        {
            for (int j = 0; j < width; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
        // dolní část
        else
        {
            for (int s = 0; s < indent; s++)
                Console.Write("  ");

            for (int j = 0; j < smallWidth; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
    }
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}