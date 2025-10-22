ConsoleColor color = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;

string again = "a";
while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("#################################");
            Console.WriteLine("##### Vykresleni obdelniku  #####");
            Console.WriteLine("#################################");
            Console.WriteLine("#####     Patrik Hečko      #####");
            Console.WriteLine("#################################");
            Console.WriteLine("");

            // Načtení stran obdélníku
            int a, b;

            Console.Write("Zadejte délku strany a (šířka): ");
            
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
                Console.Write("Zadejte celé kladné číslo pro stranu a: ");

            Console.Write("Zadejte délku strany b (výška): ");
            
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
                Console.Write("Zadejte celé kladné číslo pro stranu b: ");

            Console.WriteLine();

            // Vykreslení obdélníku
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
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