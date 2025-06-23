using static System.Runtime.InteropServices.JavaScript.JSType;

namespace chat3
{
    internal class Program
    {
        public class ReprezentacjaBin 
        {
            public int bin;
            public ReprezentacjaBin(int bin)
            {
                this.bin = bin;
            }

            string binary(int bin) 
            {
                string binary = "";
                for (int i = 0; i < 4; i++)
                {
                    if (bin%2==1)
                    {
                        binary += "1";
                    }
                    else
                    {
                        binary += "0";
                    }
                    bin /= 2;
                }
                char[] chars = binary.ToCharArray();
                string result = string.Empty;
                for (int i = chars.Length-1; i>-1; i--) 
                {
                    result += chars[i];
                }
                return result;
            }

            int zero(int bin) 
            {
                int count = 0;
                string b = binary(bin);
                foreach (char c in b)
                {
                    if (c == '0') count++;
                }
                return count;
            }
            int jeden(int bin)
            {
                int count = 0;
                string b = binary(bin);
                foreach(char c in b) 
                {
                    if (c == '1') count++;
                }
                return count;
            }

            public void Wypisz() 
            {
                Console.WriteLine($"Liczba: {bin}");
                Console.WriteLine($"Binarnie: {binary(bin)}");
                Console.WriteLine($"Zera: {zero(bin)}");
                Console.WriteLine($"Jedynki: {jeden(bin)}");
            }
        }

        static void Main(string[] args)
        {
            ReprezentacjaBin bin = new ReprezentacjaBin(13);
            bin.Wypisz();
        }
    }
}
