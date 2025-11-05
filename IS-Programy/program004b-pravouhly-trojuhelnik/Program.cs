 ConsoleColor originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;

        string again = "a";
        while (again.ToLower() == "a")
        {
            Console.Clear();
            Console.WriteLine("#################################");
            Console.WriteLine("#####   Výběr úrovně obrázku  #####");
            Console.WriteLine("#################################");
            Console.WriteLine("#####     Patrik Hečko        #####");
            Console.WriteLine("#################################");
            Console.WriteLine();

            Console.WriteLine("Vyber obtížnost (a tím i typ obrazce):");
            Console.WriteLine("1) Lehký (Plný čtverec)");
            Console.WriteLine("2) Střední (Písmeno Z)");
            Console.WriteLine("3) Těžký (Kosočtverec)");
            Console.Write("Volba: ");

            int obtiznost;
            // Ověření, že uživatel zadal číslo 1, 2 nebo 3
            while (!int.TryParse(Console.ReadLine(), out obtiznost) || obtiznost < 1 || obtiznost > 3)
                Console.Write("Neplatná volba. Zadejte číslo 1 - 3: ");

            Console.WriteLine();
            
            int velikost;
            Console.Write("Zadejte celé kladné číslo pro velikost obrazce: ");

            // Ověření, že uživatel zadal celé kladné číslo
            while (!int.TryParse(Console.ReadLine(), out velikost) || velikost <= 0)
                Console.Write("Zadejte celé kladné číslo pro velikost: ");

            Console.WriteLine();
            // ----------------------------------------

            if (obtiznost == 1)
            {
                Console.WriteLine($"Lehký obrázek - plný čtverec (Velikost: {velikost}x{velikost}):");
                for (int i = 0; i < velikost; i++)
                {
                    for (int j = 0; j < velikost; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
            else if (obtiznost == 2)
            {
                Console.WriteLine($"Střední obrázek - písmeno Z (Velikost: {velikost}x{velikost}):");
                for (int i = 0; i < velikost; i++)
                {
                    for (int j = 0; j < velikost; j++)
                        Console.Write((i == 0 || i == velikost - 1 || j == velikost - 1 - i) ? "*" : " ");
                    Console.WriteLine();
                }
            }
            else if (obtiznost == 3)
            {
                Console.WriteLine($"Těžký obrázek - kosočtverec (Základní rozměr: {velikost}x{velikost}):");
                int center = velikost / 2;
                for (int i = 0; i < velikost; i++)
                {
                    for (int j = 0; j < velikost; j++)
                        Console.Write((Math.Abs(i - center) + Math.Abs(j - center) == center) ? "*" : " ");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte 'a' a poté Enter.");
            again = Console.ReadLine();
        }