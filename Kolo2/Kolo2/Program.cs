using System.ComponentModel.DataAnnotations;

namespace Kolo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many matches were played this seaseon? ");
            int matchNumber = int.Parse(Console.ReadLine());

            int[] goals = new int[matchNumber];

            for (int i = 0; i < matchNumber; i++)
            {
                Console.Write($"Number of goals in {i+1} match: ");
                goals[i] = int.Parse(Console.ReadLine());
            }

            AnalyzeGoals(goals, out int sumGoal, out int max, out double avg);
            Console.WriteLine($"Sum of goals: {sumGoal}");
            Console.WriteLine($"Avg goals per match: {string.Format("{0:F2}",avg)}"); //2 miejsca po przecinku
            Console.WriteLine($"Most goals in single match: {max}");
        }
        static void AnalyzeGoals(int[] goals, out int sumOfGoals, out int max,out double mathavg) 
        {
            sumOfGoals = 0;
            foreach (int item in goals)
            {
                sumOfGoals += item;
            }

            mathavg = sumOfGoals / goals.Length;
            //avgGoals = Math.Round(mathavg, 2);

            //max wartosc
            max = goals[0];
            foreach (int item in goals) 
            {
                if (item > max)
                { 
                    max = item;
                }
            }
            
        }
    }
}
