namespace temp
{
    internal class Program
    {
        public class TempRecord
        {
            // Array of temperature values
            float[] temps =
           [
               56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
           ];



            public int Length => temps.Length;

            public float[] celsjus => oblicz();

            public string[] jak => stopnie();

            public float this[int index]
            {
                get { return temps[index]; }
                set { temps[index] = value; }
            }


            float[] oblicz()
            {
                float[] c = new float[Length];
                for (int i = 0; i < Length; i++)
                { c[i] = (temps[i] - 30) / 2; }
                return c;
            }

            string[] stopnie()
            {
                string[] c = new string[Length];
                for (int i = 0; i < Length; i++)
                {
                    if (temps[i] <= 60)
                    {
                        c[i] = "chlodno";
                    }
                    else if (temps[i] > 80)
                    { c[i] = "cieplo"; }
                    else { c[i] = "umiarkowanie"; }
                }
                return c;
            }
        }
        static void Main(string[] args)
        {

            TempRecord y = new TempRecord();

            // Use the indexer's set accessor
            y[3] = 58.3F;
            y[5] = 60.1F;
            y[9] = 89.3F;

            // Use the indexer's get accessor
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine($"Element #{i} = {y[i]}");
                Console.WriteLine($"Element #{i} w Celsjuszach = {y.celsjus[i]}");
                Console.WriteLine($"Element #{i} jak {y.jak[i]}");
            }

        }
    }
}
