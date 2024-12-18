namespace podatek
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obliczenie podatku");
            Console.Write("Podaj dochód: ");
            string userInput = Console.ReadLine();

            CalculateTax(userInput);
        }

        static void CalculateTax(string userInput)
        {
            int userIn = int.Parse(userInput);

            if (userIn > 10000 && userIn <= 30000)
            {
                double result = (userIn - 10000) * 0.1;
                Console.Write($"Podatek do zapłacenia: {result} zł");
            }
            else if (userIn > 30000)
            {
                double result = (20000 * 0.1) + (userIn - 30000) * 0.2;

                Console.Write($"Podatek do zapłacenia: {result} zł");
            }
        }
    }
}
