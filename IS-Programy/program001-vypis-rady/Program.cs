ConsoleColor color = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;

string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("###############################################################");
    Console.WriteLine("##### Program vypise radu cisel od 1 do zadaneho cisla n. #####");
    Console.WriteLine("###############################################################");
    Console.WriteLine("#####                    Patrik Hečko                     #####");
    Console.WriteLine("###############################################################");
    Console.WriteLine("");
    
        Console.Write("Zadej první číslo: ");
        int first = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Zadej poslední číslo: ");
        int last = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Zadej krok: ");
        int step = int.Parse(Console.ReadLine() ?? "1");

        if (step <= 0)
        {
            Console.WriteLine("! Krok musí být větší než 0 !");
            return;
        }

        // Výpis řady čísel
        for (int i = first; i <= last; i += step)
        {
            Console.WriteLine(i);
        }

    Console.Write("Zadejte 'a' pro opakovani: ");
    again = Console.ReadLine() ?? "";
}   