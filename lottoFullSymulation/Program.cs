namespace lottoFullSymulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] randomNumbers = new int[6];

            

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                int los = rnd.Next(1, 50);

                while (randomNumbers.Contains(los)) 
                {
                    los = rnd.Next(1, 50);
                }

                randomNumbers[i] = los;

            }


            foreach (var item in randomNumbers) 
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
