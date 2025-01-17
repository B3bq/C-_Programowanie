namespace Cezar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test
            //char letter = 'a';//A=65, Z=90, a=97, z=122
            //int letterValue = letter;
            //Console.Write($"{letter}={letterValue}");


            Console.Write("Enter text to encription: ");
            string userText = Console.ReadLine();
            Console.Write("Enter length of key: ");
            int key = int.Parse(Console.ReadLine()) % 26;

            for (int i = 0; i < userText.Length; i++) 
            {
                if (userText[i] >= 65 && userText[i] <= 90)
                {
                    int currentLetterValue = userText[i] + key;
                    if (currentLetterValue > 90) { currentLetterValue -= 26; }
                    Console.Write((char)currentLetterValue);
                }
                else if (userText[i] >= 97 && userText[i] <= 122)
                {
                    int currentLetterValue = userText[i] + key;
                    if (currentLetterValue > 122) { currentLetterValue -= 26; }
                    Console.Write((char)currentLetterValue);
                }
                else 
                {
                    Console.Write(userText[i]);
                }
            }
        }
    }
}
