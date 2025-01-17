namespace Flamaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string userString = Console.ReadLine();

            string resultString = string.Empty;

            int counter = 0;

            for (int i = 0; i < userString.Length;) 
            {
                char currentLetter = userString[i];
                while (i < userString.Length && currentLetter == userString[i]) 
                { 
                    counter++; 
                    i++;
                }
                if (counter == 1)
                {
                    resultString += currentLetter;
                }
                else if(counter == 2)
                {
                    resultString += currentLetter;
                    resultString += currentLetter;
                }
                else 
                {
                    resultString += currentLetter;
                    resultString += counter;
                }
                counter = 0;
            }
            Console.WriteLine(resultString);
        }
    }
}
