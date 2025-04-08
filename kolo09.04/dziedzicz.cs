namespace Zadanie2_1a;
class liczbaA
{
    public int a;
    public liczbaA(int a)
    {
        this.a = a;
    }
    public bool CzyLiczbaArmstronga(int liczba)
    {
        int sumaCyfr = 0, temp = liczba, iloscCyfr = liczba.ToString().Length;
        while (temp > 0)
        {
            int cyfra = temp % 10;
            sumaCyfr += (int)Math.Pow(cyfra, iloscCyfr);
            temp /= 10;
        }
        return sumaCyfr == liczba;
    }
    //funkcja zgodnie z treścą zadania powinna sprawdzać własność
    // dla a , a nie dla parametru Nie jest to wielki problem , ale ma 
    // swoje skutki w ew. uruchomieniu tej funkcji- patrz kod
}
class liczbaB : liczbaA
{
    int b;
    public liczbaB(int a, int b) : base(a)
    {
        this.b = b;
    }
    public void wypiszLiczbyArmstronga()
    {
        Console.WriteLine($"Liczby armstronga w zakresie od {a} do {b}: ");
        for (int i = a; i <= b; i++)
        {
            if (CzyLiczbaArmstronga(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        //przykładowe uruchomienie klasy bazowej
        liczbaA x = new liczbaA(153);
        Console.WriteLine(x.CzyLiczbaArmstronga(153));
        //przykładowe uruchomienie klasy potomnej
        liczbaB liczby = new liczbaB(1, 1000);
        liczby.wypiszLiczbyArmstronga();
    }
}