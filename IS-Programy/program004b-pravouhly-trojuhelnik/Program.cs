ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;

        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("#################################");
            Console.WriteLine("##### Vykreslení trojúhelníku #####");
            Console.WriteLine("#################################");
            Console.WriteLine("#####       Patrik Hečko       #####");
            Console.WriteLine("#################################");
            Console.WriteLine("");

            int vyska;

            Console.Write("Zadejte výšku trojúhelníku: ");

            while (!int.TryParse(Console.ReadLine(), out vyska) || vyska <= 0)
                Console.Write("Zadejte celé kladné číslo pro výšku: ");

            Console.WriteLine();

            // Vykreslení pravouhlého trojúhelníku
            for (int i = 1; i <= vyska; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //###########################################################################################
            // Opakování programu
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
            again = Console.ReadLine();
        }