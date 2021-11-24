using DivisorsConsole;
bool exit = false;

while (!exit)
{
    try
    {
        Service.Divisors = new();
        Service.PrimeDivisors = new();

        Console.WriteLine("Enter a positive number: ");
        uint number = uint.Parse(Console.ReadLine());

        Service.DivisorsChecker(number);

        Console.WriteLine($"Your number is: {number}");

        Service.ShowList("Divisors", Service.Divisors);
        Service.ShowList("Prime divisors", Service.PrimeDivisors);

    }
    catch (Exception error)
    {
        Console.WriteLine($"\nEnter a valid number... \n Error:{error}");
    }

    Console.ReadLine();
    Console.Clear();
}





