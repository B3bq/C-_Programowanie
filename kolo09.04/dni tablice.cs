namespace dni
{
    internal class Program
    {
        static void Main(string[] args)
        {
          days days = new days();
            for (int i = 0; i < days.len; i++)
            {
                Console.WriteLine("ang: {0}", days.nameDays[i]);
                Console.WriteLine("pl: {0}", days.dni[i]);
            }
        }
    }
    class days 
    {
        public string[] nameDays =  [ "mon", "tue", "wed", "thu", "fri", "sat", "sun" ];

        public int len => nameDays.Length;

        public string[] dni => dnipl();

        public string this[int index] 
        {
            get { return nameDays[index]; }
            set { nameDays[index] = value; }
        }

        string[] dnipl()
        {
            string[] c = new string[len];
            for (int i = 0; i < len; i++)
            {
                switch (nameDays[i])
                {
                    case "mon":
                        c[i] = "pon";
                        break;
                    case "tue":
                        c[i] = "wto";
                        break;
                    case "wed":
                        c[i] = "sro";
                        break;
                    case "thu":
                        c[i] = "czw";
                        break;
                    case "fri":
                        c[i] = "pia";
                        break;
                    case "sat":
                        c[i] = "sob";
                        break;
                    case "sun":
                        c[i] = "ndz";
                        break;
                }
            }
            return c;
        }
    }
}
