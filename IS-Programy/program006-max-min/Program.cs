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

    Console.WriteLine("############################");
    Console.WriteLine("Pseudonáhodná čísla: ");

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(low, top + 1);
        Console.Write(myRandNumbs[i] + ", ");
    }


    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int postMax = 0;
    int postMin = 0;

    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            postMax = i;
        }
        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            postMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("############################");
    Console.WriteLine("Maximum: " + max + " na pozici " + postMax);
    Console.WriteLine("Minimum: " + min + " na pozici " + postMin);

    if (max >= 3)
    {
        Console.WriteLine();
        Console.WriteLine("Obrazec pro maximum:");
        for (int i = 0; i < max; i++)
        {
            int spaces, stars;
            if (i < max / 2)
            {
                spaces = i;

                stars = max - 2 * i;
            }
            else
            {
                spaces = max - i - 1;
                if (max % 2 == 0) //sude
                {
                    stars = 2 * (i - max / 2) + 2;
                }
                else //liche
                {
                    stars = 2 * (i - max / 2) + 1;
                }
            }
            for (int j = 0; j < spaces; j++)
            {
                ConsoleColor colorpicture = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" ");
            }
            for (int j = 0; j < stars; j++)
            {
                ConsoleColor colorpicture = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Obrazec se nevykresli, protože maximum je menší než 3.");
    }
    
    ConsoleColor originalColor2 = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
