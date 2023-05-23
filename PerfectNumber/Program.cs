namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 28; // The number to check

            bool isPerfect = IsPerfectNumber(number);

            Console.WriteLine($"{number} is{(isPerfect ? "" : " not")} a perfect number.");

            Console.ReadLine();
        }

        static bool IsPerfectNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum == number;
        }
    }
}