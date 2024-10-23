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
        public string GetStringReport()
        {
            string result;
            if (Dealers.Count != 0)
            {
                result = $"Всего автосалонов: {Dealers.Count}";
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
    }
}
