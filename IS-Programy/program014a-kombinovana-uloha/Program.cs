ConsoleColor originalColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Generátor čísel  *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Patrik Hečko *******");
    Console.WriteLine("****************************");
    Console.WriteLine();

    Console.Write("Zadejte kolik bude čísel v řadě (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    Console.Write("Zadejte dolni mez řady (celé číslo): ");
    int low;
    while (!int.TryParse(Console.ReadLine(), out low))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez řady znovu: ");
    }

    Console.Write("Zadejte horní mez řady (celé číslo): ");
    int top;
    while (!int.TryParse(Console.ReadLine(), out top))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez řady znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("############################");
    Console.WriteLine("kolik bude čísel v řadě: " + n);
    Console.WriteLine("dolní mez: " + low);
    Console.WriteLine("horní mez: " + top);
    Console.WriteLine("############################");
    Console.WriteLine();

    int[] myRandNumbs = new int[n];

    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("############################");
    Console.WriteLine("Pseudonáhodná čísla: ");

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(low, top + 1);
        Console.Write(myRandNumbs[i] + (i < n - 1 ? ", " : ""));
    }
    Console.WriteLine();

    int min = myRandNumbs[0];
    int max = myRandNumbs[0];

    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] < min) min = myRandNumbs[i];
        if (myRandNumbs[i] > max) max = myRandNumbs[i];
    }

    Console.WriteLine();
    Console.Write($"Maximum: {max}, všechny pozice maxima: ");
    bool first = true;
    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] == max)
        {
            if (!first) Console.Write("; ");
            Console.Write(i + 1);
            first = false;
        }
    }
    Console.WriteLine();

    Console.Write($"Minimum: {min}, všechny pozice minima: ");
    first = true;
    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] == min)
        {
            if (!first) Console.Write("; ");
            Console.Write(i + 1);
            first = false;
        }
    }
    Console.WriteLine();

    int left = 0;
    int right = n - 1;
    int k = 0;

    while (left < right)
    {
        for (int i = left; i < right; i++)
        {
            if (myRandNumbs[i] < myRandNumbs[i + 1])
            {
                int temp = myRandNumbs[i];
                myRandNumbs[i] = myRandNumbs[i + 1];
                myRandNumbs[i + 1] = temp;
                k = i;
            }
        }
        right = k;

        for (int i = right; i > left; i--)
        {
            if (myRandNumbs[i - 1] < myRandNumbs[i])
            {
                int temp = myRandNumbs[i];
                myRandNumbs[i] = myRandNumbs[i - 1];
                myRandNumbs[i - 1] = temp;
                k = i;
            }
        }
        left = k;
    }

    Console.WriteLine();
    Console.WriteLine("Pole po seřazení algoritmem Skaher sort:");
    for (int i = 0; i < n; i++)
    {
        Console.Write(myRandNumbs[i] + (i < n - 1 ? ", " : ""));
    }
    Console.WriteLine();

    int distinctCount = 1;
    int? druhe = null, treti = null, ctvrte = null;

    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] != myRandNumbs[i - 1])
        {
            distinctCount++;
            if (distinctCount == 2) druhe = myRandNumbs[i];
            if (distinctCount == 3) treti = myRandNumbs[i];
            if (distinctCount == 4) ctvrte = myRandNumbs[i];
        }
        if (distinctCount >= 4) break;
    }

    Console.WriteLine();
    Console.WriteLine($"Druhé největší číslo: {(druhe.HasValue ? druhe.ToString() : "N/A")}");
    Console.WriteLine($"Třetí největší číslo: {(treti.HasValue ? treti.ToString() : "N/A")}");
    Console.WriteLine($"Čtvrté největší číslo: {(ctvrte.HasValue ? ctvrte.ToString() : "N/A")}");

    double median;
    if (n % 2 != 0)
    {
        median = myRandNumbs[n / 2];
    }
    else
    {
        median = (myRandNumbs[(n / 2) - 1] + myRandNumbs[n / 2]) / 2.0;
    }

    Console.WriteLine($"Medián generovaných čísel = {median}");

    if (ctvrte.HasValue)
    {
        string binary = Convert.ToString(ctvrte.Value, 2);
        Console.WriteLine($"Čtvrté největší číslo převedené do binární soustavy: {ctvrte}(2) = {binary}");
    }

    if (treti.HasValue)
    {
        int vyska = (int)median;
        int sirka = treti.Value;

        Console.WriteLine($"Obrazec - výška = medián ({vyska}); šířka = třetí největší číslo ({sirka})");

        int sirkaStonku = (int)Math.Ceiling(sirka / 3.0);
        int vyskaPricky = (int)Math.Ceiling(vyska / 3.0);

        if (sirkaStonku < 1) sirkaStonku = 1;
        if (vyskaPricky < 1) vyskaPricky = 1;

        int startPricky = (vyska - vyskaPricky) / 2;
        int konecPricky = startPricky + vyskaPricky;
        
        // Zde je oprava pro vycentrování křížku
        int odsazeni = (sirka - sirkaStonku) / 2;

        for (int radek = 0; radek < vyska; radek++)
        {
            if (radek >= startPricky && radek < konecPricky)
            {
                for (int s = 0; s < sirka; s++) Console.Write("*");
            }
            else
            {
                for (int m = 0; m < odsazeni; m++) Console.Write(" ");
                for (int s = 0; s < sirkaStonku; s++) Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}