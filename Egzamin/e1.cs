using System;
using System.Collections.Generic;
using System.Linq;

// Klasa bazowa
public class CiagZnakow
{
    protected List<string> lancuchy;

    public virtual void WczytajDane(int n)
    {
        lancuchy = new List<string>();
        Console.WriteLine($"Podaj {n} łańcuchów (każdy 10 małych liter):");
        for (int i = 0; i < n; i++)
        {
            string tekst;
            do
            {
                tekst = Console.ReadLine();
            } while (tekst.Length != 10 || !tekst.All(c => c >= 'a' && c <= 'z'));

            lancuchy.Add(tekst);
        }
    }

    public virtual void Przetworz()
    {
        Console.WriteLine("\nPosortowane łańcuchy:");
        foreach (var tekst in lancuchy)
        {
            var posortowany = new string(tekst.OrderBy(c => c).ToArray());
            Console.WriteLine(posortowany);
        }
    }
}

// Klasa potomna – polimorficzne zachowanie
public class CiagZnakowZFiltracja : CiagZnakow
{
    public override void Przetworz()
    {
        Console.WriteLine("\nŁańcuchy zawierające literę 'z':");
        foreach (var tekst in lancuchy)
        {
            if (tekst.Contains('z'))
            {
                Console.WriteLine(tekst);
            }
        }
    }
}

// Program główny
class Program
{
    static void Main()
    {
        CiagZnakow[] obiekty = new CiagZnakow[2];

        obiekty[0] = new CiagZnakow();
        obiekty[0].WczytajDane(3); // przykładowo 3 elementy
        obiekty[0].Przetworz();

        obiekty[1] = new CiagZnakowZFiltracja();
        obiekty[1].WczytajDane(3);
        obiekty[1].Przetworz();
    }
}
