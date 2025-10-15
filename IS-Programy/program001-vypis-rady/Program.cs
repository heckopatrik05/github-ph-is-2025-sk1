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

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
    }

    Console.Write("Zadejte diferenci (celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte diferenci znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

//Vypis rady

    Console.WriteLine("");
    Console.WriteLine("####################################");
    Console.WriteLine("##### Zadali jste tyto hodnoty #####");
    Console.WriteLine("První číslo řady: {0}", first);
    Console.WriteLine("Poslední číslo řady: {0}", last);
    Console.WriteLine("Diference: ", step);
    Console.WriteLine("####################################");
    Console.WriteLine("První číslo řady je: {0}, Poslední číslo: {1}, Diference: {2}", first, last, step);
    Console.WriteLine("####################################");

}