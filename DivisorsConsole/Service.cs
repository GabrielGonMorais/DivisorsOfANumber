namespace DivisorsConsole
{
    public sealed class Service
    {
        public static List<uint> PrimeDivisors { get; set; }
        public static List<uint> Divisors { get; set; }

        public static void DivisorsChecker(uint number)
        {
            for (uint i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Divisors.Add(i);

                    if (Service.PrimeNumChecker(i))
                    {
                        PrimeDivisors.Add(i);
                    }
                }
            }
        }
        public static bool PrimeNumChecker(uint number)
        {
            bool isPrime = true;

            if (number == 0)
                isPrime = false;

            for (uint i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        public static void ShowList(string name, List<uint> list)
        {
            Console.Write($"{name} : ");
            foreach (int number in list)
            {
                Console.Write($"{number}  ");
            }
            Console.WriteLine("");
        }
    }
}
