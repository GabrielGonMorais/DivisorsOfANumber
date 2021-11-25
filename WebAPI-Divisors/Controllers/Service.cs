namespace WebAPI_Divisors.Controllers
{
    public class Service
    {
        public static Divisors DivisorsChecker(uint number)
        {
            Divisors divisors = new();

            for (uint i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Divisor.Add(i);

                    if (Service.PrimeNumChecker(i))
                    {
                        divisors.PrimeDivisors.Add(i);
                    }
                }
            }
            return divisors;
        }

        public static bool PrimeNumChecker(uint number)
        {
            bool isPrime = (number != 0);

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
    }
}
