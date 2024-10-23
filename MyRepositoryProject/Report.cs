namespace MyRepositoryProject
{
    public class Report
    {
        public List<Dealer> Dealers = [];
        public Report()
        {

        }
        public Report(List<Dealer> deals) => Dealers = deals;
        private List<Dealer> GetMaxSaleCar()
        {
            int maxCount = Dealers.Max(n => n.Sale.Count);
            return Dealers.Where(n => n.Sale.Count == maxCount).ToList();
        }
        private List<Dealer> GetMinSaleCar()
        {
            int minCount = Dealers.Min(n => n.Sale.Count);
            return Dealers.Where(n => n.Sale.Count == minCount).ToList();
        }
        public string GetStringDealersInfo()
        {
            string result = "\nАвтосалоны:";
            foreach (var dealer in Dealers)
            {
                result += $"\n\t{dealer.DealerName} продал:";
                foreach (var car in dealer.Sale)
                    result += $"\n\t\tавто {car.CarName} по цене {car.CarPrice}";
            }
            return result;
        }
        public string GetStringReport()
        {
            string result;
            if (Dealers.Count != 0)
            {
                result = $"Всего автосалонов: {Dealers.Count}";
                result += GetStringDealersInfo();
                result += "\nМаксимальное количество продаж у:";
                List<Dealer> d = GetMaxSaleCar();
                foreach (Dealer dealer in d)
                    result += $"\n{dealer.DealerName} ({dealer.Sale.Count})";
                result += "\nМинимальное количество продаж у:";
                d = GetMinSaleCar();
                foreach (Dealer dealer in d)
                    result += $"\n{dealer.DealerName} ({dealer.Sale.Count})";
            }
            else
                result = "Нет данных для составления отчета";
            return result;

        }
        public bool IsEmpty() => Dealers.Count == 0;
    }
}
