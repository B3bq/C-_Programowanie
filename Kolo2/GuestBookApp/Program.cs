
namespace GuestBookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            int totalGuests = 0;
            while (true)
            {
                int counter;
                Console.Clear();
                WelcomeMessage();
                guests.Add(GetPartyName()); //dodanie do listy nazwy
                totalGuests += GetPartySize(); //zlicznie gosci w zmiennej totalGuest
                string response = AskToContinue(); //pytanie, czy kontynulowac
                if (response != "yes") break; //jesli odpowiedz nie jest tak przerwi
            }
            DisplayGuests(guests);
            DisplayGuestCount(totalGuests);
        }

        private static void DisplayGuestCount(int totalGuests)
        {
            Console.WriteLine($"The total count for this eveningwas {totalGuests}");
        }

        private static void DisplayGuests(List<string> guests)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Guest List:");
            //wypisanie listy
            for (int i = 0; i < guests.Count; i++)
            {
                string item = guests[i];
                Console.WriteLine($"{i+1}. {item}");
            }
            Console.WriteLine("Thank you for everyone who attended");
        }

        private static int GetPartySize()
        {
            while (true)
            {
                Console.Write("How many people are in your party: ");
                string partySize = Console.ReadLine();
                if (int.TryParse(partySize, out int number)) //spr czy nie litera
                {
                    return number;
                }
                Console.WriteLine("Please enter a number not letter"); 
            }
        }

        private static string GetPartyName()
        {
            Console.Write("What's your party/family name: ");
            string partyName = Console.ReadLine();
            return partyName;
        }

        private static string AskToContinue()
        {
            Console.Write("Are there more guest coming? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();
            return response;
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Guest Book App");
            Console.WriteLine("*****************************");
        }
    }
}
