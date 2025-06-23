namespace chat1
{
    internal class Program
    {
        public class osoba 
        {
            public int lata; public string name;
            public osoba(string name, int lata) {this.name=name; this.lata = lata; }

            public virtual int IleDniZycia() 
            {
                return lata*365;
            }
            public void wynik()
            {
                Console.WriteLine(2 * IleDniZycia());
            }
        }
        public class Student : osoba
        {
            public int sesja;
            public Student(string name, int lata, int sesja):base(name, lata)
            {
                this.sesja = sesja;
                Statystyka.liczbaStudentow++;
            }

            public override int IleDniZycia()
            {
                return 7 * sesja + 365 * lata;
            }

        }

        public static class Statystyka 
        {
            public static int liczbaStudentow = 0;
            public static void WypiszLiczbeStudentow() 
            {
                Console.WriteLine($"Liczba studentów: {liczbaStudentow}");
            }
        }

        static void Main(string[] args)
        {
            osoba s = new Student("Marek", 24, 5);
            Console.WriteLine("Wiek: {0}", s.IleDniZycia());
            Statystyka.WypiszLiczbeStudentow();
        }
    }
}
