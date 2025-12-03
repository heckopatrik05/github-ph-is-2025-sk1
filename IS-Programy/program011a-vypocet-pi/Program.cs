string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpočet čisla pi *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Patrik Hečko *******");
    Console.WriteLine("****************************");
    Console.WriteLine();

    Console.Write("Zadejte požadovanou přesnost výpočtu (např. 0.001): ");
    double precision;

    while (!double.TryParse(Console.ReadLine(), out precision))
    {
        Console.Write("Zadejte přesnost např. 0.001: ");
    }

    double i = 1;           
    double piCtvrt = 1;     
    double znamenko = 1;

    while (1 / i > precision)
    {          
        i = i + 2; 
        znamenko = znamenko * -1;                         
        piCtvrt = piCtvrt + (znamenko * 1/ i); 

        Console.WriteLine("Aktuální hodnota pi/4: " + piCtvrt);
    }

    double pi = piCtvrt * 4;
    Console.WriteLine("Hodnota čísla pi je přibližně: " + pi);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}
