using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_5__Final_week_Review_
{
    public class InvalidAgeException : Exception
    {
        public int Age { get;}

        public InvalidAgeException(int age) : base($"Age {age} is not valid. Age must be between 18 and 65.")
        {
            Age = age;
        }

    }

    class AgeException
    {
        public static void CheckAge()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 18 || age > 65)
                {
                    throw new InvalidAgeException(age);
                }
                else
                {
                    Console.WriteLine($"Your age is valid: {age}");
                }
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred", e.Message);
            }
        }
    }
}
