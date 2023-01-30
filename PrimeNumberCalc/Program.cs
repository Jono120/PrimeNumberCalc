namespace PrimeNumberCalc
{
    class NumberCalc
    {
        // This block will create a console screen for the user to input numbers to check what ones are Prime Numbers
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number : ");

            number = int.Parse(Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " is a prime number\n");
                }
                else
                {
                    Console.Write(i + " is not a prime number\n");
                }
            }
        }

        // This block will check for which number that gets placed in the console to see what ones are Prime Numbers
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}