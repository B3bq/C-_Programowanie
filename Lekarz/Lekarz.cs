namespace Lekarz
{
    internal class Lekarz
    {
        static void Main(string[] args)
        {
            List<string> pacjent = new List<string>();
            bool isExitPressed = false;

            while (isExitPressed == false)
            {
                Console.Clear();
                string userChoice = DoctorQueueMenu();
                
                switch (userChoice.ToLower())
                {
                    case "d":
                        AddPatient(pacjent);
                        Console.Write("Kliknij dowolny przycisk, aby kontynułować...");
                        Console.ReadKey();
                        break;
                    case "p":
                        ServePatient(pacjent);
                        Console.Write("Kliknij dowolny przycisk, aby kontynułować...");
                        Console.ReadKey();
                        break;
                    case "l":
                        DisplayQueue(pacjent);
                        Console.Write("Kliknij dowolny przycisk, aby kontynułować...");
                        Console.ReadKey();
                        break;
                    case "s":
                        GetPatientsBefore(pacjent);
                        Console.Write("Kliknij dowolny przycisk, aby kontynułować...");
                        Console.ReadKey();
                        break;
                    case "w":
                        isExitPressed = true;
                        break;
                    default:
                        Console.WriteLine("Brak tekiej opcji w menu");
                        Console.ReadKey();
                        Console.Write("Kliknij dowolny przycisk, aby kontynułować...");
                        break;
                } 
            }
        }

        private static void GetPatientsBefore(List<string> pacjent)
        {
            Console.Write("Imię i nazwisko pacjenta: ");
            string namePatient = Console.ReadLine();
            int counter = 0;
            if (pacjent.Contains(namePatient))
            {
                for (int i = 0; i < pacjent.Count(); i++)
                {
                    if (pacjent[i] != namePatient)
                    {
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"Liczba osób w kolejce przed: {counter}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Brak pacjenta o takim imieniu i nazwisku");
            }
        }

        private static void ServePatient(List<string> pacjent)
        {
            if (pacjent.Count == 0)
            {
                Console.WriteLine("Brak pacjentów do przyjęcia. Dzień wolny :)");
            }
            else
            {
                Console.WriteLine($"{pacjent[0]}");
                pacjent.RemoveAt(0);
            }
        }

        private static void AddPatient(List<string> pacjent)
        {
            Console.Write("Imię i nazwisko pacjenta: ");
            string pacient = Console.ReadLine();
            if (pacient == string.Empty)
            {
                Console.WriteLine("Podaj imię i nazwisko pacjenta");
            }
            else
            {
                pacjent.Add(pacient);
                Console.WriteLine("Dodano pacjenta do listy");
            }
        }

        private static void DisplayQueue(List<string> pacjent)
        {
            if (pacjent.Count() == 0) 
            {
                Console.WriteLine("Brak pacjentów na liście");
            }
            else
            {
                for (int i = 0; i < pacjent.Count() ; i++)
                {
                    Console.WriteLine($"{i + 1}. {pacjent[i]}");
                }
            }
        }

        private static string DoctorQueueMenu()
        {
            Console.WriteLine("\nDoctor queue app");
            Console.WriteLine("----------------------------");
            Console.WriteLine("[D]odaj pacjent do kolejki");
            Console.WriteLine("[P]rzyimj pacjenta");
            Console.WriteLine("[L]ista pacjentów oczekujących");
            Console.WriteLine("[S]prawdź który w kolejce");
            Console.WriteLine("[W]yjdź");
            Console.Write("> ");
            string userChoice = Console.ReadLine();
            return userChoice;
        }
    }
}
