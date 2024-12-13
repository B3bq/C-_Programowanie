namespace Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pierwszy sposob deklaracji tablic
            string[] firstNames = new string[5];

            firstNames[0] = "Janek";
            firstNames[1] = "Tom";
            firstNames[2] = "Bob";
            firstNames[3] = "Rob";
            firstNames[4] = "Sue";

            for (int i = 0; i < 5; i++)
            {
                Console.Write(firstNames[i] + ", ");
            }
            Console.WriteLine();


            firstNames[0] = "Bil";
            Console.WriteLine(firstNames[0]);

            Console.WriteLine();
            Console.WriteLine();


            //drugi sposob deklaracji tablicy
            string data = "Clark, Bruce, Arthur, Barry, Diana, Hal, Jack";

            string[] firrstNamesOfDCHeroes = data.Split(',');

            //ostatni element tablicy Console.WriteLine(firrstNamesOfDCHeros[firrstNamesOfDCHeros.Length-1]);

            foreach (var item in firrstNamesOfDCHeroes) 
            {
                Console.Write(item);
            }
            Console.WriteLine();

            //inicjalizacja tablicy

            string[] lastNamesOfDCHeroes = new string[] {"Kent", "Wayne", "Curry", "Allen", "Prince", "Jordan"};

            string[] alterEgos = new string[] {"Superman", "Batman", "Aquaman", "Flash", "Wonder Woman", "Hulk"};

            for (int i = 0; i < lastNamesOfDCHeroes.Length; i++)
            {
                Console.WriteLine($"{firrstNamesOfDCHeroes[i]} {lastNamesOfDCHeroes[i]} - {alterEgos[i]}");
            }
        }
    }
}
