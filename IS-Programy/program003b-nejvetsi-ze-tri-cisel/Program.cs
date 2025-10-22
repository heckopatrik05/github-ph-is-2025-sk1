ConsoleColor color = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;

string again = "a";
while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("#################################");
            Console.WriteLine("##### Největší ze tří čísel #####");
            Console.WriteLine("#################################");
            Console.WriteLine("#####     Patrik Hečko      #####");
            Console.WriteLine("#################################");
            Console.WriteLine("");

            // Načtení čísel
            int a, b, c;

            Console.Write("Zadejte číslo - hodnota A: ");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.Write("Nezadali jste celé číslo! Zadejte znovu hodnotu A: ");

            Console.Write("Zadejte číslo - hodnota B: ");
            while (!int.TryParse(Console.ReadLine(), out b))
                Console.Write("Nezadali jste celé číslo! Zadejte znovu hodnotu B: ");

            Console.Write("Zadejte číslo - hodnota C: ");
            while (!int.TryParse(Console.ReadLine(), out c))
                Console.Write("Nezadali jste celé číslo! Zadejte znovu hodnotu C: ");

            // Pokud je číslo záporné, uděláme z něj kladné
            if (a < 0) a = -a;
            if (b < 0) b = -b;
            if (c < 0) c = -c;

            //###########################################################################################
            // Algoritmus podle vývojového diagramu – nalezení největšího čísla

            Console.WriteLine();
            if (a > b)
            {
                if (a > c)
                    Console.WriteLine($"Největší číslo je: {a}");
                else
                    Console.WriteLine($"Největší číslo je: {c}");
            }
            else
            {
                if (b > c)
                    Console.WriteLine($"Největší číslo je: {b}");
                else
                    Console.WriteLine($"Největší číslo je: {c}");
            }

            //###########################################################################################
            // Opakování programu
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
            again = Console.ReadLine();
        }      