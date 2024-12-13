namespace NWW_NWD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");    
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value: ");
            int b = int.Parse(Console.ReadLine());
            int nwd = NWD(a, b);
            int nww = NWW(a, b);

            Console.WriteLine($"NWD({a}, {b}) = {nwd}");
            Console.WriteLine($"NWW({a}, {b}) = {nww}");
        }

        static int NWD(int a, int b) // NWD(a, 0) = a b->0
            // b = a mod b
            // a = b (wartosc b przed obliczeniem b = a mod b)
        {
            while (b != 0) 
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;    
        }

        static int NWW(int a, int b) 
        {
            return a * b /NWD(a, b);
        }
    }
}
