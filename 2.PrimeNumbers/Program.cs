public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (isPrime(i))
                Console.WriteLine(i);
        }

        for (int i = 1; i <= num; i++)
        {
            isPrimeSqrt(i);
        }

        Console.WriteLine($"With Sqrt: {isPrimeSqrtIterationsCount}");
        Console.WriteLine($"Without Sqrt: {isPrimeIterationsCount}");
    }

    public static int isPrimeIterationsCount = 0;
    public static bool isPrime(int num)
    {
        for (int i = 2; i < num; i++)
        {
            isPrimeIterationsCount++;
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static int isPrimeSqrtIterationsCount = 0;
    public static bool isPrimeSqrt(int num)
    {
        for (int i = 2; i < Math.Sqrt(num); i++)
        {
            isPrimeSqrtIterationsCount++;
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}