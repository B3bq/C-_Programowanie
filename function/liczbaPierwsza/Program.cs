namespace PrimeNumber;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{number} is a prime number");
            Console.ResetColor();
        }
        else 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{number} isn't a prime number");
            Console.ResetColor();
        }

        
    }

    static int dzielniki(int a) 
    {
        for (int i = 1; i <= a; i++)
        {
            int x = i % a;
            Console.Write($"{x}");
        }
        return a;
    }
    
    static bool IsPrime(int a)
    {
        if (a <= 1) return false;
        if (a == 2) return true;
        if (a % 2 == 0) return false;

        int border = (int)Math.Floor(Math.Sqrt(a));

        for (int i = 3; i <= border; i += 2)
        {
            if (a % i == 0) return false;
        }

        return true;
        
    }
}