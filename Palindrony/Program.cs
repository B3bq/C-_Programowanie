
namespace Palindrony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            string userNumber = Console.ReadLine();
            int intNumber = int.Parse(userNumber);
            int counter = 0;

            do
            {
                string reverseTextNumber = ReverseString(userNumber);
                if (userNumber == reverseTextNumber) 
                {
                    break;
                }

                int reverseIntNumber = int.Parse(reverseTextNumber);
                intNumber += reverseIntNumber;
                userNumber = intNumber.ToString();
                counter++;
            }while(true);

            Console.Write($"{userNumber} {counter}");

        }

        private static string ReverseString(string userNumber)
        {
            char[] chars = userNumber.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
