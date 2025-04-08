namespace nowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nwd nwd = new nwd();
            nwd.pisz();
        }
    }
    public class nwd 
    {
        int liczba; int liczba2; int liczba3;
        public nwd() 
        {
            Console.WriteLine("Podaj liczbe: ");
            this.liczba = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 2 liczbe: ");
            this.liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj 3 liczbe: ");
            this.liczba3 = int.Parse(Console.ReadLine());
        }

        public int NWD(int a, int b) 
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
        public void pisz() 
        {
            int wynik = this.NWD(this.NWD(liczba, liczba2), liczba3);
            Console.WriteLine($"NWD: {wynik}");
        }
    }
}
