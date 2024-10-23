namespace MyRepositoryProject.Tests
{
    [TestClass]
    public class ReportTests
    {
        [TestMethod]
        public void IsEmpty_0_trueReturned()
        {
            Report report = new();

            bool actual = report.IsEmpty();

            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void IsEmpty_2Dealers_falseReturned()
        {
            Report report = new([new(), new()]);

            bool actual = report.IsEmpty();

            Assert.IsFalse(actual);
        }
    }
}
