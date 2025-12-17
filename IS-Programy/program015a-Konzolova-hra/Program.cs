using System;

class Program
{
    static void Main()
    {
        // --- PŘÍPRAVA GRAFIKY ---
        // Pole řetězců, kde každý prvek (index 0 až 6) představuje jednu fázi šibenice.
        // Index 0 = prázdná šibenice, Index 6 = oběšenec.
        // Zavináč (@) umožňuje psát string na více řádků.
        string[] obrazkySibenice = new string[]
        {
            @"
              +---+
              |   |
                  |
                  |
                  |
                  |
            =========
            ",
            @"
              +---+
              |   |
              O   |
                  |
                  |
                  |
            =========
            ",
            @"
              +---+
              |   |
              O   |
              |   |
                  |
                  |
            =========
            ",
            @"
              +---+
              |   |
              O   |
             /|   |
                  |
                  |
            =========
            ",
            @"
              +---+
              |   |
              O   |
             /|\  |
                  |
                  |
            =========
            ",
            @"
              +---+
              |   |
              O   |
             /|\  |
             /    |
                  |
            =========
            ",
            @"
              +---+
              |   |
              O   |
             /|\  |
             / \  |
                  |
            =========
            "
        };

        string again = "a";

        // --- HLAVNÍ SMYČKA PROGRAMU ---
        // Umožňuje hrát hru znovu a znovu, dokud uživatel nezmění proměnnou 'again'.
        while (again == "a")
        {
            Console.Clear(); // Vyčistí konzoli před novou hrou
            Console.ForegroundColor = ConsoleColor.White; 

            // ==========================================
            // ČÁST 1: ZADÁVÁNÍ TAJNÉHO SLOVA (HRÁČ 1)
            // ==========================================
            Console.WriteLine("=== HRÁČ 1 ===");
            Console.WriteLine("Zadej tajné slovo (Hráč 2 se nedívá!):");
            
            string tajneSlovo = "";
            
            // Nekonečný cyklus pro čtení znaků po jednom (kvůli hvězdičkám)
            while (true)
            {
                // Console.ReadKey(true) přečte klávesu, ale NEVYPÍŠE ji na obrazovku (to je to 'true')
                ConsoleKeyInfo key = Console.ReadKey(true);

                // Pokud uživatel stiskne ENTER a slovo není prázdné -> ukončíme zadávání
                if (key.Key == ConsoleKey.Enter && tajneSlovo.Length > 0)
                {
                    break; 
                }
                // Pokud uživatel stiskne BACKSPACE (mazání)
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (tajneSlovo.Length > 0)
                    {
                        // Smažeme poslední znak z paměti (zkrátíme string o 1)
                        tajneSlovo = tajneSlovo.Substring(0, tajneSlovo.Length - 1);
                        // Smažeme hvězdičku z obrazovky: posun zpět (\b), mezera, posun zpět (\b)
                        Console.Write("\b \b");
                    }
                }
                // Pokud je to běžný znak (písmeno, číslo...), nikoliv speciální klávesa (F1, Ctrl...)
                else if (!char.IsControl(key.KeyChar)) 
                {
                    tajneSlovo += key.KeyChar; // Přidáme znak do proměnné
                    Console.Write("*");        // Na obrazovku vypíšeme jen hvězdičku
                }
            }

            // Převedeme slovo na velká písmena, aby "a" bylo stejné jako "A"
            tajneSlovo = tajneSlovo.ToUpper();
            
            Console.Clear(); // Smažeme obrazovku, aby Hráč 2 neviděl počet hvězdiček

            // ==========================================
            // ČÁST 2: PŘÍPRAVA NA HÁDÁNÍ (HRÁČ 2)
            // ==========================================
            Console.WriteLine("=== HRÁČ 2 ===");
            Console.WriteLine("Slovo je zadáno. Můžeš začít hádat!");

            // Vytvoříme pole znaků pro skryté slovo (např. ['_', '_', '_'])
            // Používáme char[], protože string se špatně mění (je immutable)
            char[] hadaneSlovo = new char[tajneSlovo.Length];
            
            // Nastavíme počáteční stav
            int chyby = 0;      // Počítadlo chyb (index do pole obrázků)
            int maxChyb = 6;    // Maximální počet chyb (poslední index pole obrázků)
            bool vitezstvi = false;

            // Proměnná pro ukládání historie tipů (např. "A B X ")
            string pouzitaPismena = "";

            // Naplníme pole podtržítky
            for (int i = 0; i < hadaneSlovo.Length; i++)
            {
                hadaneSlovo[i] = '_';
            }

            // ==========================================
            // HERNÍ SMYČKA (Běží, dokud hráč neprohraje nebo nevyhraje)
            // ==========================================
            while (chyby < maxChyb && !vitezstvi)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear(); // DŮLEŽITÉ: Smažeme konzoli, aby se obrázek "animoval" na stejném místě

                // Vykreslíme aktuální fázi šibenice podle počtu chyb
                Console.WriteLine(obrazkySibenice[chyby]);

                // Vypíšeme stav hry
                Console.WriteLine("Tajné slovo: " + new string(hadaneSlovo)); // Převedeme char[] zpět na string pro výpis
                Console.WriteLine($"Použitá písmena: {pouzitaPismena}");
                Console.WriteLine($"Zbývá životů: {maxChyb - chyby}");
                Console.Write("Hádej písmeno: ");
                
                // Načteme jeden znak od hráče a převedeme na velké písmeno
                char tip = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine(); 

                // --- KONTROLA 1: OPAKOVANÝ TIP ---
                // Funkce .Contains zjistí, zda string 'pouzitaPismena' už obsahuje 'tip'
                if (pouzitaPismena.Contains(tip))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nPozor! Písmeno '{tip}' už jsi zkoušel.");
                    Console.WriteLine("Stiskni libovolnou klávesu a zkus to znovu...");
                    Console.ReadKey();
                    continue; // Klíčové slovo CONTINUE skočí ihned na začátek cyklu (přeskočí zbytek kódu)
                }

                // Pokud je tip nový, přidáme ho do seznamu použitých
                pouzitaPismena += tip + " ";

                bool uhodlVtomtoKole = false;

                // --- KONTROLA 2: JE PÍSMENO VE SLOVĚ? ---
                // Projdeme celé tajné slovo znak po znaku
                for (int i = 0; i < tajneSlovo.Length; i++)
                {
                    if (tajneSlovo[i] == tip)
                    {
                        hadaneSlovo[i] = tip; // Odhalíme písmeno na správné pozici
                        uhodlVtomtoKole = true; // Zaznamenáme úspěch
                    }
                }

                // --- VYHODNOCENÍ KOLA ---
                if (uhodlVtomtoKole)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nSuper! Písmeno '{tip}' tam je.");
                }
                else
                {
                    chyby++; // Zvyšujeme počet chyb -> příště se vykreslí horší obrázek
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nChyba! Písmeno '{tip}' tam není.");
                }

                // Čekáme na stisk klávesy, aby si hráč stihl přečíst výsledek před smazáním obrazovky
                Console.WriteLine("Pokračuj stiskem klávesy...");
                Console.ReadKey();

                // --- KONTROLA VÍTĚZSTVÍ ---
                // Pokud v poli 'hadaneSlovo' už není žádné podtržítko, hráč vyhrál
                if (!new string(hadaneSlovo).Contains('_'))
                {
                    vitezstvi = true;
                }
            }

            // ==========================================
            // KONEC HRY (VYHODNOCENÍ)
            // ==========================================
            Console.Clear(); // Vyčistíme naposledy pro finální obrazovku
            
            if (vitezstvi)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(obrazkySibenice[chyby]); // Zobrazíme aktuální stav (vítězný)
                Console.WriteLine("\nGRATULUJI! Uhodl jsi slovo: " + tajneSlovo);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(obrazkySibenice[maxChyb]); // Zobrazíme plnou šibenici (poslední obrázek)
                Console.WriteLine("\nPROHRA! Byl jsi oběšen.");
                Console.WriteLine("Tajné slovo bylo: " + tajneSlovo);
            }
            Console.WriteLine("==============================");

            // Dotaz na opakování
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pro opakování hry stiskněte klávesu 'a', jinak ukončete.");
            again = Console.ReadLine();
        }
    }
}