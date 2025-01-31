namespace Opady
{
    internal class Opady
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] iloscOpadow = new int[7];
            for (int i = 0; i < iloscOpadow.Length; i++)
            {
                int los = rnd.Next(0, 31);
                iloscOpadow[i] = los;
            }

            string[] dniTygodnia = { "Pon", "Wto", "Śro", "Czw", "Pią", "Sob", "Nie" };

            Console.WriteLine("Analiza opadów deszczu");

            int liczbadni = Question();
            GetRainfallStatistics(iloscOpadow, dniTygodnia, liczbadni);

        }

        private static void GetRainfallStatistics(int[] iloscOpadow, string[] dniTygodnia, int liczbadni)
        {
            for (int i = 0; i < liczbadni; i++)
            {
                Console.Write("\n" + dniTygodnia[i] + ": ");
                for (int j = 0; j < iloscOpadow[i]; j++)
                {
                    Console.Write('\u2588');
                }
                Console.Write($" {iloscOpadow[i]} mm");
            }

            int sumRainfall = 0;
            for (int i = 0; i < liczbadni; i++) 
            {
                sumRainfall += iloscOpadow[i];
            }

            double avgRainfall = sumRainfall / liczbadni;

            int maxValue = iloscOpadow[0];
            string maxDay = dniTygodnia[0];
            for (int i = 0; i < liczbadni; i++) 
            {
                if (iloscOpadow[i] > maxValue) 
                {
                    maxValue = iloscOpadow[i];
                    maxDay = dniTygodnia[i];
                }
            }

            int minValue = iloscOpadow[0];
            string minDay = dniTygodnia[0];
            for (int i = 0; i < liczbadni; i++)
            {
                if (iloscOpadow[i] < minValue)
                {
                    minValue = iloscOpadow[i];
                    minDay = dniTygodnia[i];
                }
            }

            Console.WriteLine($"\nNajwieksza ilość opadów: {maxDay} ({maxValue} mm)");
            Console.WriteLine($"Najminejsza ilość opadów: {minDay} ({minValue} mm)");
            Console.WriteLine($"Średnia ilość opadów: {avgRainfall:F2}");
        }

        private static int Question()
        {
            while (true)
            {
                Console.Write("Poadj liczbę dni tygodnia: ");
                string liczbadni = Console.ReadLine();
                if (int.TryParse(liczbadni, out int number) && (number > 0 && number <=7))
                {
                    return number;
                }
                Console.WriteLine("Wprowadź liczb z zakresu 1-7"); 
            }
        }
    }
}
