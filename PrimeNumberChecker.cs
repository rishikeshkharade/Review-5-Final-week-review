using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_5__Final_week_Review_
{
    class PrimeNumberChecker
    {
        public static void PrimeChecker()
        {
                try
                {
                    Console.Write("Enter a number to check if it is prime: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Number must be positive");
                    }

                    bool isPrime = IsPrime(number);

                    if (isPrime)
                    {
                        Console.WriteLine($"{number} is a prime number.");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is not a prime number");
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");

                }
            }
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(number);

            for (int i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0)
                    return false;
            {
                    }
            }return true;
                
            }
        }
}
