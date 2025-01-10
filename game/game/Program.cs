namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter key: ");
            char key =Console.ReadKey().KeyChar;
            
            Console.WriteLine();

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Write($"Pressed key: {keyInfo.Key}");
        }
    }
}
