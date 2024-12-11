namespace spoj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of the user number");

            int number = 0;

            for (int i = 1; i > 0; i++) 
            {
                Console.Write("Enter your number: ");
                int userNumber = int.Parse(Console.ReadLine());
                int result = number + userNumber;
                Console.WriteLine(result);
                number = result;
            }
        }
    }
}
