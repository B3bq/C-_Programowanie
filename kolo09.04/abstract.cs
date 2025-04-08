namespace figury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj bok: ");
            double a = double.Parse(Console.ReadLine());
            kwadrat k = new kwadrat(a);
            Console.WriteLine("Pole: {0}", k.pole());
            Console.WriteLine("Obw: {0}", k.obw());

            Console.WriteLine("Podaj bok: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugi bok: ");
            double b = double.Parse(Console.ReadLine());
            prostokat p = new prostokat(a, b);
            Console.WriteLine("Pole: {0}", p.pole());
            Console.WriteLine("Obw: {0}", p.obw());

            Console.Write("podaj boki trojkata: ");
            a=double.Parse(Console.ReadLine());
            b=double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            trojkat t = new trojkat(a, b, c);
            Console.WriteLine("Pole: {0}", t.pole());
            Console.WriteLine("Obw: {0}", t.obw());
        }
        abstract class figura 
        {
            public double a;
            abstract public double pole();
            abstract public double obw();
        }
        class trojkat : figura 
        {
            double b, c;
            public trojkat(double a, double b, double c) { this.a = a; this.b = b; this.c = c; }
            public override double pole()
            {
                double p = obw()/2;
                double wynik = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                return wynik;
            }
            public override double obw()
            {
                return (a + b + c);
            }
        }
        class kwadrat:figura
        {
            public kwadrat(double a) { this.a = a; }
            public override double pole() { return a*a; }
            override public double obw() { return a*4; }
        }
        class prostokat : kwadrat 
        {
            double b;
            public prostokat(double a, double b): base(a) { this.b = b; }
            public double pole() 
            {
                return (a * b);
            }
            public double obw() { return ((a * 2) + (b * 2)); }
        }
    }
}
