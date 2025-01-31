namespace Array2DStatistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array dimiention: ");
            int n = int.Parse(Console.ReadLine());

            //deklaracja macierzy nxn
            int[,] matrix = new int[n, n];

            Random rnd = new Random();

            //uzupelnienie macierzy
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(n * n);
                }
            }


            //wydruk macierzy
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i,j], 3} ");//sformatowane, zeby kolumny landnie wygladaly
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //min wartosc

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----Min Values----------");
            
            
            for (int j = 0; j < n; j++)
            {
                int minValue = matrix[0, j];

                for (int i = 1; i < n; i++)
                {
                    if (matrix[i, j] < minValue)
                    {
                        minValue = matrix[i, j];
                    }
                }
                Console.Write($"{minValue,3}");
            }
            
            
            Console.ResetColor();

            Console.WriteLine();

            //max wartosc

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-----Max Values----------");


            for (int j = 0; j < n; j++)
            {
                int maxValue = matrix[0, j];

                for (int i = 1; i < n; i++)
                {
                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                    }
                }
                Console.Write($"{maxValue,3}");
            }


            Console.ResetColor();
            Console.WriteLine();

            //srednia arytmetyczna macierzy
            int sum = 0;

            foreach (int item in matrix) 
            { 
                 sum += item;
            }
            double mean = (double)sum / matrix.Length;
            Console.Write($"Avrage of matrix: {mean:F2}");//F liczba miejsc po przecinku

            Console.WriteLine();

            //ile elementow jest mniejszych niz srednia

            int counter = 0;

            foreach (var item in matrix)
            {
                if (item < mean) { counter++; }
            }
            Console.Write($"How many numbers is lower than avg: {counter}");
        }
    }
}
