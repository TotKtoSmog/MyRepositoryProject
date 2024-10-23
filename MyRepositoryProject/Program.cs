namespace MyRepositoryProject
{
    internal class Program
    {
        static void Main()
        {
            Dealer a = new("Аврора",
                [ new("Mazda x7",607750),
                new("Nissan X-Trail",831300),
                new("Kia Sorento",1683000)
                ]);
            Dealer b = new("TopCar",
                [ new("Hyundai Solaris",168000),
                new("Hyundai Creta 2019",925650),
                new("Hyundai Tucson",1348100)
                ]);
            Dealer c = new("VolvoCenter",
                [ new("Volvo 240",750000),
                new("Volvo S80",696150),
                new("Volvo XC90 2011",736100),
                new("Volvo XC60 2013",78200),
                new("Volvo V40 2013",1026800),
                ]);
            Report r = new([a, b, c]);

            Console.WriteLine(r.GetStringReport());
        }
    }
}
