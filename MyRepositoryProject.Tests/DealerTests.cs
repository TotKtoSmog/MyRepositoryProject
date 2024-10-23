namespace MyRepositoryProject.Tests
{
    [TestClass]
    public class DealerTests
    {
        [TestMethod]
        public void IsEmpty_Empty_trueReturned()
        {
            Dealer dealer = new();

            bool actual = dealer.IsEmpty();

            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsEmpty_TopCar_Car_falseReturned()
        {
            Dealer dealer = new("TopCar", [new("Mazda", 1000)]);

            bool actual = dealer.IsEmpty();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsEmptySale_Empty_trueReturned()
        {
            Dealer dealer = new();

            bool actual = dealer.IsEmptySale();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsEmptySale_TopCar_Empty_trueReturned()
        {
            Dealer dealer = new("TopCar", []);

            bool actual = dealer.IsEmptySale();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void GetMaxPriceSale_TopCar_Mazda_1000_1000Returned()
        {
            double expected = 1000;
            Dealer dealer = new("TopCar", [new("Mazda", 1000)]);

            double actual = dealer.GetMaxPriceSale();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMaxPriceSale_TopCar_Empty_0Returned()
        {
            double expected = 0;
            Dealer dealer = new("TopCar", []);

            double actual = dealer.GetMaxPriceSale();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetMaxPriceSale_TopCar_Many_10000Returned()
        {
            double expected = 10000;
            Dealer dealer = new("TopCar", [new("Mazda", 1000), new("Mazda", 500), new("Kia", 10000)]);

            double actual = dealer.GetMaxPriceSale();

            Assert.AreEqual(expected, actual);
        }
    }
}