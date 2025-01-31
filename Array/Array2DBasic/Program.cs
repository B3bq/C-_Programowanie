namespace Array2DBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tworzenie tablicy 2 wymiarowej
            int[,] array2D = new int[2, 3];

            array2D[0, 0] = 1;
            array2D[0, 1] = 2;
            array2D[0, 2] = 3;
            array2D[1, 0] = 4;
            array2D[1, 1] = 5;
            array2D[1, 2] = 6;

            Console.WriteLine(array2D[0, 0] + " " + array2D[0, 1]);
            Console.WriteLine($"Array lenght: {array2D.Length}");
            Console.WriteLine($"Array row lenght: {array2D.GetLength(0)}");
            Console.WriteLine($"Array column lenght: {array2D.GetLength(1)}");

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }

            //deklarowanie wartosci startowych tabklicy 2 wymiarowej

            string[,] textArray2D =
                {
                    {"Hello", "World"},
                    {"Nice", "Day"}
                };

            //Nice World
            Console.Write($"{textArray2D[1,0]} {textArray2D[0,1]}");
            Console.WriteLine();

            //za ppomoca jednej petli mozna wypisac elementy tablicy
            foreach (var item in textArray2D)
            {
                Console.WriteLine(item);
            }


        }
    }
}
