        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;

        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("#################################");
            Console.WriteLine("#####  Výběr úrovně obrázku #####");
            Console.WriteLine("#################################");
            Console.WriteLine("#####     Patrik Hečko      #####");
            Console.WriteLine("#################################");
            Console.WriteLine("");

            Console.WriteLine("Vyber obtížnost:");
            Console.WriteLine("1) Lehký");
            Console.WriteLine("2) Střední");
            Console.WriteLine("3) Těžký");
            Console.Write("Volba: ");

            int obtiznost;
            while (!int.TryParse(Console.ReadLine(), out obtiznost) || obtiznost < 1 || obtiznost > 3)
                Console.Write("Zadejte číslo 1 - 3: ");

            Console.WriteLine();

            if (obtiznost == 1)
            {
                Console.WriteLine("Lehký obrázek - plný čtverec:");
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
            else if (obtiznost == 2)
            {
                Console.WriteLine("Střední obrázek - písmeno Z:");
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                        Console.Write((i == 0 || i == 7 || j == 7 - i) ? "*" : " ");
                    Console.WriteLine();
                }
            }
            else if (obtiznost == 3)
            {
                Console.WriteLine("Těžký obrázek - kosočtverec:");
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                        Console.Write((Math.Abs(i - 3) + Math.Abs(j - 3) == 3) ? "*" : " ");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte 'a'");
            again = Console.ReadLine();
        }

        Console.ForegroundColor = color;

