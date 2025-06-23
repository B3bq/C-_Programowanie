namespace chat2
{
    internal class Program
    {
        public class AnalizaCiagu 
        {
            public List<int> list;
            public AnalizaCiagu(List<int> list)
            {
                this.list = list;
            }

            public virtual void Opis() 
            {
                bool parzyste =true;
                bool niepa = true;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0) niepa = false;
                    else if (list[i] % 2 == 1) parzyste = false;
                }
                if (parzyste)
                {
                    Console.WriteLine("Parzyste");
                }
                else if (niepa)
                {
                    Console.WriteLine("Nieparzyste");
                }
                else
                {
                    Console.WriteLine("Mieszane");
                }
            }
        }

        public class ZaawansowanaAnalizaCiagu : AnalizaCiagu
        {
            public ZaawansowanaAnalizaCiagu(List<int> list) : base(list) { }

            public override void Opis()
            {
                int count = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 1; j <= list[i]; j++)
                    {
                        if (j * j == list[i]) count++;
                    }
                }
                Console.WriteLine($"Ilość liczb kwadratowych: {count}");
            }
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int> {1,2,5,16,2,25 };
            AnalizaCiagu ciag = new AnalizaCiagu(list);
            ciag.Opis();
            AnalizaCiagu c = new ZaawansowanaAnalizaCiagu(list);
            c.Opis();
        }
    }
}
