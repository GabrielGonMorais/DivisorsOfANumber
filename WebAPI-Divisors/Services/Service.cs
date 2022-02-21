namespace WebAPI_Divisors.Services
{
    public class Service
    {

        public static Divisors DivisorsChecker(uint number)
        {
            var divisors = new Divisors();

            for (uint i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Divisor.Add(i);

                    if (PrimeNumChecker(i))
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
