
namespace Ciag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadź ciąg znaków: ");
            string userString = Console.ReadLine();
            Console.WriteLine("-----------------------");

            string longestSubstring = FindLongestSubstring(userString);
            Console.WriteLine($"Najdłuższy podciąg: {longestSubstring} - {longestSubstring.Length}");
        }

        private static string FindLongestSubstring(string userString)
        {
            Dictionary<char, int> seen = new Dictionary<char, int>();
            int start = 0; ; 
            int maxLenght = 0;
            int maxStart = 0;

            for (int i = 0; i < userString.Length; i++)
            {
                if (seen.ContainsKey(userString[i]) && seen[userString[i]] >= start)
                {
                    start = seen[userString[i]] + 1;
                }

                seen[userString[i]] = i;

                if (i - start + 1 > maxLenght)
                {
                    maxLenght = i - start + 1;
                    maxStart = start;
                }
            }
            return userString.Substring(maxStart, maxLenght);
        }
    }
}
