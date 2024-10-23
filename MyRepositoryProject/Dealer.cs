namespace MyRepositoryProject
{
    public class Dealer
    {
        public string DealerName
        {
            get => _dealerName;
            set => _dealerName = value;
        }
        private string _dealerName = new("");
        public List<Car> Sale = [];
        public Dealer() => DealerName = "Empty";
        public Dealer(string dealerName, List<Car> sale)
        {
            DealerName = dealerName;
            Sale = sale;
        }
    }
}
