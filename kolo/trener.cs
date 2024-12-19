using System.Data.SqlTypes;
using System.Security.Principal;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace tranzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Tranżer pierwiastkowania");

            int z = userLvl();

            program(z);

            //a loop for play again
            for (int i = 1; i >0; i ++)
            {
                Console.WriteLine();
                Console.Write("Do you want play again? (Y/N): ");
                string again = Console.ReadLine();

                if (again == "Y" || again == "y")
                {
                    Console.Clear();
                    z = userLvl();
                    program(z);
                }
                else
                {
                    Environment.Exit(0);       
                } 
            }
        }

        //menu of choose
        static int userLvl() 
        {
            Console.WriteLine("Poziom 1: Pierwiastki w zakresie od 1 do 100");
            Console.WriteLine("Poziom 2: Pierwiastki w zakresie od 101 do 1024");
            Console.WriteLine("Poziom 3: Pierwiastki w zakresie od 1025 do 10 000");

            Console.Write("Wybierz poziom: ");
            int intlvl = int.Parse(Console.ReadLine());
            
            Console.Clear();
            return intlvl;//return a option
        }

        //function program XD
        static void program(int lvl) 
        {
            Console.Write("Podaj liczbę przykładów: ");
            int liczbaPrzykladow = int.Parse(Console.ReadLine());

            Random rnd = new Random();//intialization a random
            
            Console.Clear();


            //switch case for a each options 
            switch (lvl) 
            { 
                case 1:
                    int points = 0;
                    for (int i = 0; i < liczbaPrzykladow; i++)
                    {
                        int x = rnd.Next(1, 11);
                        int to100 = x*x;//random roots to 100
                        Console.Write('\u221A'+$"{to100} = ");
                        int answer = int.Parse(Console.ReadLine());
                        Thread.Sleep(100);
                        Console.Clear();

                        //counting points
                        root(to100, answer, points);
                        points = root(to100, answer, points);
                          
                    }
                    summary(points, liczbaPrzykladow);
                    break;
                case 2:
                    points = 0;
                    for (int i = 0; i < liczbaPrzykladow; i++) 
                    {
                        int x = rnd.Next(11, 33);
                        int to1024 = x * x;//random roots to 1024
                        Console.Write('\u221A' + $"{to1024} = ");
                        int answer = int.Parse(Console.ReadLine());
                        Thread.Sleep(100);
                        Console.Clear();

                        //counting points
                        root(to1024, answer, points);
                        points = root(to1024, answer, points);
                    }
                    summary(points, liczbaPrzykladow);
                    break;
                case 3:
                    points = 0;
                    for (int i = 0; i < liczbaPrzykladow; i++) 
                    {
                        int x = rnd.Next(33, 101);
                        int to10k = x * x;//random roots to 10k
                        Console.Write('\u221A' + $"{to10k} = ");
                        int answer = int.Parse(Console.ReadLine());
                        Thread.Sleep(100);
                        Console.Clear();

                        //counting points
                        root(to10k, answer, points);
                        points = root(to10k, answer, points);
                    }
                    summary(points, liczbaPrzykladow);
                    break;
            }
        }

        static int root(double rndPier, int userAnswer, int points) 
        { 
            int rootResult = (int)Math.Sqrt(rndPier);//a value of random root


            if (rootResult == userAnswer)
            {
                //Console.ForegroundColor = ConsoleColor.Green;//font is green
                Console.BackgroundColor = ConsoleColor.Green;//background is green
                Console.Write('\u221A' + $"{rndPier} = {userAnswer}");
                Console.ResetColor();
                
                //wait a second for a new example
                Thread.Sleep(1000);
                points++;
            }
            else 
            {
                Console.BackgroundColor = ConsoleColor.Red;//background is red
                Console.Write('\u221A' + $"{rndPier} = {userAnswer}");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write('\u221A' + $"{rndPier} = {rootResult}");
                Console.ResetColor();

                //waiting for a new example
                Thread.Sleep(1000);
            }

            Console.Clear();

            return points;//return a number of points
        }

        static void summary(int points, int questions) 
        {
            //summary of whole program
            Console.Clear();
            Console.Write($"Number of eared points: {points}");
            Console.WriteLine();
            Console.Write($"Number of questions: {questions}");

            if (questions >= 10) 
            {
                Console.WriteLine();
                Console.Write($"Percent value of questions: {points*100/questions}%");
            }
        }
    }
}
