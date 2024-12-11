namespace functionBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        //sayHello();
        //printAppIntro();

        //Console.Write("Enter your text intro: ");
        //string userInput = Console.ReadLine();
        //printUserIntro(userInput);


        //RectangleArea(4, 5);

        //double sum = Addition(3, 2);
        //Console.WriteLine(sum);

        //int square = Square(2);
        //Console.WriteLine(square);
        //double dsquare = Square(4.23);
        //Console.WriteLine(dsquare);

        Console.WriteLine(Factorial(10));

    }

    //1 Funkcje bez parametrów i bez zwracania wartości
    static void sayHello() 
    {
        Console.WriteLine("Hello everyone");
    }

    static void printAppIntro() 
    {
        string message = "Welcome in my tutorial!";

        //for (int i = 0; i < message.Length; i++) 
        //{
        //    Console.Write('\u2550');
        //}

        string border = new string('\u2550', message.Length+2);
        
        Console.WriteLine('\u2554' + border + '\u2557');
        Console.WriteLine('\u2551' + " " + message + " " + '\u2551');
        Console.WriteLine('\u255A' + border + '\u255D');
        
    }

    //2 Funkcje z parametrami, ale bez zwracania wartości

    static void printUserIntro(string message)
    {

        //for (int i = 0; i < message.Length; i++) 
        //{
        //    Console.Write('\u2550');
        //}

        string border = new string('\u2550', message.Length + 2);

        Console.WriteLine('\u2554' + border + '\u2557');
        Console.WriteLine('\u2551' + " " + message + " " + '\u2551');
        Console.WriteLine('\u255A' + border + '\u255D');

    }

    static void RectangleArea(double a, double b) 
    {
        Console.WriteLine($"Rectangle area with a = {a}, b={b} is {a*b}");
    }

    //3 Funkcje zwracające wartość

    static double Addition(double a, double b) 
    {
        double sum = a + b;

        return sum;
    }

    //4 Przeciążanie funkcji (overloading)

    static int Square(int n) 
    {
        return n * n;
    }

    static double Square(double x) 
    { 
        return x * x;
    }

    //5 Funkcje rekurencyjne

    static int Factorial(int n) 
    {
        Console.WriteLine($"Wywołanie rekurencyjne dla n ={n}");

        if (n <= 1) return 1;
        
        
        return n*Factorial(n-1);
    }

}