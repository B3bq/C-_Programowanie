
namespace TODOlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> todos = new List<string>();
            bool isExitPressed = false;


            while (isExitPressed == false)
            {
                Console.Clear();

                Console.WriteLine("Welcome in TODO List App!");
                Console.WriteLine("-------------------------");
                Console.WriteLine("\n[S]ee all TODOs");
                Console.WriteLine("[A]dd a TODOs");
                Console.WriteLine("[R]emove a TODOs");
                Console.WriteLine("[E]xit");
                Console.Write("Choose menu option: ");
                string userChoice = Console.ReadLine();

                switch (userChoice.ToLower())
                {
                    case "s":
                        SeeAllTodos(todos);
                        Console.Write("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "a":
                        AddTodo(todos);
                        Console.ReadKey();
                        Console.Write("Press any key to continue...");
                        break;
                    case "r":
                        RemoveTodo(todos);
                        Console.ReadKey();
                        Console.Write("Press any key to continue...");
                        break;
                    case "e":
                        isExitPressed = true;
                        break;
                    default:
                        Console.WriteLine("Invalid menu option");
                        Console.ReadKey();
                        Console.Write("Press any key to continue...");
                        break;
                }
            }
        }

        private static void RemoveTodo(List<string> todos)
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("You don't have any TODOs to remove");
            }
            else
            {
                SeeAllTodos(todos);
            }

            Console.Write("Enter number to remove a TODO: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int index);

            if (isNumber && index > 0 && index <= todos.Count)
            {
                todos.RemoveAt(index - 1);
                Console.WriteLine("Your quest has been removed successfully");
            }
            else 
            {
                Console.WriteLine("Index out of range");
            }
        }

        private static void AddTodo(List<string> todos)
        {
            Console.Write("Add a new quest: ");
            string quest = Console.ReadLine();

            if (quest == string.Empty)
            {
                Console.WriteLine("Your TODO heve no description");
            }
            else if (todos.Contains(quest))
            {
                Console.WriteLine("Your TODO exists");
            }
            else
            {
                todos.Add(quest);
                Console.WriteLine("Your TODO have been added successfully");
            }

        }

        private static void SeeAllTodos(List<string> todos)
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("You don't have any to do");
            }
            else
            {
                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"{i+1} {todos[i]}");
                }
            }
        }
    }
}
