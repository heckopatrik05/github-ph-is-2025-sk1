ConsoleColor color = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Green;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("##########################################");
    Console.WriteLine("##### Ciferný součet číslic a součin #####");
    Console.WriteLine("##########################################");
    Console.WriteLine("#####           Patrik Hečko         #####");
    Console.WriteLine("##########################################");
    Console.WriteLine("");

    Console.Write("Zadejte číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte číslo znovu: ");
    }
    
    //Opakovani programu
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}