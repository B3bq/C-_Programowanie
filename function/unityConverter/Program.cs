namespace unityConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int day = 3;
            //string dayName = day switch
            //{
            //    1 => "Monday",
            //    2 => "Tuesday",
            //    3 => "Wendsday",
            //    4 => "Thursday",
            //    5 => "Friday",
            //    6 => "Saturday",
            //    7 => "Sunday",
            //    _ => throw new Exception("Invalid day")
            //};

            //Console.WriteLine(dayName);

            double converterValue = CoverterLengthUnits(25, "cm", "m");

            Console.WriteLine(converterValue);

        }

        static double CoverterLengthUnits(double value, string unitFrom, string unitTo) 
        {
            //1 Convertion from unitFrom to meters

            double valueInMeters = unitFrom switch
            {
                "km" => value * 1000,
                "m" => value,
                "dm" => value / 10,
                "cm" => value / 100, 
            };

            //2 From meters to unitTo

            return unitTo switch 
            {
                "km" => valueInMeters,
                "m" => valueInMeters / 1000,
                "dm" => valueInMeters * 10,
                "cm" => valueInMeters * 100,
            };
        }

    }
}
