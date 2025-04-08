namespace next
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe: ");
            double i = double.Parse(Console.ReadLine());
            zero z = new zero(i);
            z.pisz();

            zero e = new zero();
            e.liczb = 80703040;
            e.pisz();
        }
    }
    class zero 
    {
        double liczba;
        public zero(double liczba) 
        {
            this.liczba = liczba;
        }
        public zero() { }
        public double liczb 
        {
            get { return liczba; }
            set { liczba = value; }
        }
        double zeroCount() 
        {
            string str = liczba.ToString();
            int counter=0;
            foreach (var item in str)
            {
                if (item == '0') counter++;
            }
            return counter;
        }
        public void pisz() { Console.WriteLine("Ilosc zer: {0}", zeroCount()); }
    }
}
