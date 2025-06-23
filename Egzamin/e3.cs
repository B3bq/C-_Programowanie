namespace zadanie3
{
    public interface Iulamki 
    {
        void skroc(ref int licznik, ref int mianownik);
        void calosc(int licznik, int mianownik);
    }

    public class ulamki : Iulamki
    {
        int l1, m1, l2, m2;

        public ulamki(int l1, int m1, int l2, int m2)
        {
            this.l1 = l1;
            this.m1 = m1;
            this.l2 = l2;
            this.m2 = m2;
        }

        public void dziel() 
        {
            int nowylicznik = l1 * m2;
            int nowymianownik = l2 * m1;

            Console.WriteLine($"Wynik dzielenia: {nowylicznik}/{nowymianownik}");
            skroc(ref nowylicznik,ref nowymianownik);
            Console.WriteLine($"Po skróceniu: {nowylicznik}/{nowymianownik}");

            calosc(nowylicznik, nowymianownik);
        }

        public void skroc(ref int licznik,ref int mianownik)
        {
            int a = licznik;
            int b = mianownik;
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            licznik /= a;
            mianownik /= a;
        }
        public void calosc(int licznik,int mianownik)
        {
            int calosc = licznik / mianownik;
            int reszta = licznik % mianownik;

            if (calosc != 0)
            {
                Console.WriteLine($"Całych {calosc} i reszty {reszta}/{mianownik}");
            }
            else
            {
                Console.WriteLine($"Brak liczby całkowitej {licznik}/{mianownik}");
            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            ulamki u = new ulamki(17,12,5,8);
            u.dziel();
        }
    }
}
