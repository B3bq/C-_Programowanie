namespace przykladoweKolo
{
    internal class piramida
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Enter height of the piramid: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //loop for a empty spaces
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                //loop showing a triangles
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write('\u25B2');

                    
                    //a space after triangle
                    if (j < (2 * i - 1))
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
