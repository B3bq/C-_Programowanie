
internal class Program
{
    private static void Main(string[] args)
    {
        List<string> words = new List<string>() { "One", "TWO", "HELLO", "WORLD123", "DAY!@#", "TWO", "C#" };
        List<string> upperCaseWords = new List<string>();
        upperCaseWords = GetOnlyUpperCaseWords(words);

        foreach (string word in upperCaseWords)
        {
            Console.WriteLine(word);
        }
    }
    static List<string> GetOnlyUpperCaseWords(List<string> words)
    {
        List<string> upperWords = new List<string>();

        foreach (string word in words)
        {
            if (words.Contains(word))
            {
                continue;
            }


            bool isUpperWord = true;
            foreach (char letter in word)
            {
                if (char.IsUpper(letter) == false)
                {
                    isUpperWord = false;
                    break;
                }
            }

            if (isUpperWord)
            {
                upperWords.Add(word);
            }
        }

        return upperWords;
    }
}