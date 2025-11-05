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

    int negative = 0;
    int positive = 0;
    int zero = 0;

    int odd = 0;
    int even = 0;

    Console.WriteLine();
    Console.WriteLine("############################");
    Console.WriteLine("Pseudonáhodná čísla: ");

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(low, top + 1);
        Console.Write(myRandNumbs[i] + ", ");
        if (myRandNumbs[i] > 0)
        {
            positive++; 
        }
        else if (myRandNumbs[i] < 0)
        {
            negative++; 
        }
        else
        {
            zero++; 
        }
        if (myRandNumbs[i] % 2 == 0)
        {
            even++; 
        }
        else
        {
            odd++; 
        }
    }
    Console.WriteLine();
    Console.WriteLine("############################");
    Console.WriteLine("Kladná: {0}", positive);
    Console.WriteLine("############################");
    Console.WriteLine("Záporná: {0}", negative);
    Console.WriteLine("############################");
    Console.WriteLine("Nula: {0}", zero);
    Console.WriteLine("############################");
    Console.WriteLine("Sudé: {0}", even);
    Console.WriteLine("############################");
    Console.WriteLine("Liché: {0}", odd);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}
