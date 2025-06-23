namespace zadanie2
{
    internal class Program
    {
        public class pierwsza 
        {
            public List<string> binary;
            public int dzielnik;
            public pierwsza(int dzielnik) 
            {
               this.dzielnik = dzielnik;
                binary = new List<string>();
            }

            public virtual void wczytaj(int n) 
            {
                Console.Write("\nPodaj liczbę: ");
                for (int i = 0; i < n; i++)
                {
                    string number;
                    do
                    {
                        number = Console.ReadLine();
                    } while (number.Length > 8 && number.All(c => c == '0' || c == '1'));

                    binary.Add(number);
                }
            }

            public virtual void function() 
            {
                int licznik =0;

                foreach (var item in binary)
                {
                    int wartosc = 0;
                    foreach (char bit in item)
                    {
                        wartosc = wartosc * 2 + (bit - '0');
                    }

                    if (wartosc % dzielnik == 0)
                    {
                        licznik++;
                    }
                }

                Console.WriteLine($"Ilość liczb binarnych podzielnych przez {dzielnik}: {licznik}");
            }
        }

        public class LiczbyOsemkowe : pierwsza
        {
            public LiczbyOsemkowe(int dzielnik) : base(dzielnik) { }

            public override void wczytaj(int n)
            {
                Console.WriteLine($"Podaj {n} liczb ósemkowych (maks 8 cyfr):");
                for (int i = 0; i < n; i++)
                {
                    string oct;
                    do
                    {
                        oct = Console.ReadLine();
                    } while (!oct.All(c => c >= '0' && c <= '7') || oct.Length > 8);

                    binary.Add(oct);
                }
            }

            public override void function()
            {
                int licznik = 0;
                foreach (var oct in binary)
                {
                    int wartosc = 0;
                    foreach (char cyfra in oct)
                    {
                        wartosc = wartosc * 8 + (cyfra - '0');
                    }

                    if (wartosc % dzielnik == 0)
                        licznik++;
                }
                Console.WriteLine($"Liczb ósemkowych podzielnych przez {dzielnik}: {licznik}");
            }
        }

        static void Main(string[] args)
        {
            pierwsza p = new pierwsza(3);
            p.wczytaj(3);
            p.function();

            LiczbyOsemkowe l2 = new LiczbyOsemkowe(4);
            l2.wczytaj(3);
            l2.function();
        }
    }
}
