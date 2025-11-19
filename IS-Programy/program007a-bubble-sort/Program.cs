using System.Diagnostics;
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

    // Definice pole
    int[] myRandNumbs = new int[n];

    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("############################");
    Console.WriteLine("Pseudonáhodná čísla: ");

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(low, top + 1);
        Console.Write(myRandNumbs[i] + ", ");
    }

    int change = 0;
    int compare = 0;

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            compare++;
            if (myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int temp = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = temp;
                change++;
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine("Seřazená čísla: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write(myRandNumbs[i] + ", ");
    }
    Console.WriteLine();
    Console.WriteLine("Počet změn: " + change);
    Console.WriteLine("Počet porovnání: " + compare);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

}
