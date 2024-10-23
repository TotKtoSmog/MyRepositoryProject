namespace MyRepositoryProject
{
    public class Car
    {
        public string? CarName
        {
            get => _carName;
            set => _carName = value;
        }
        private string? _carName;
        public double CarPrice
        {
            get => _carPrice;
            set => _carPrice = value;
        }
        private double _carPrice;
        public Car()
        {
            CarName = "Empty";
            CarPrice = 0;
        }
        public Car(string carName, double carPrice)
        {
            _carName = carName;
            _carPrice = carPrice;
        }
    }
}
