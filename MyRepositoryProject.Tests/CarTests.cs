namespace MyRepositoryProject.Tests
{
    [TestClass]
    public class CarsTests
    {
        [TestMethod]
        public void IsEmpty_Empty_0_trueReturned()
        {
            Car car = new();

            bool actual = car.IsEmpty();

            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsEmpty_Mazda_10000_falseReturned()
        {
            Car car = new("Mazda", 10000);

            bool actual = car.IsEmpty();

            Assert.IsFalse(actual);
        }
    }
}