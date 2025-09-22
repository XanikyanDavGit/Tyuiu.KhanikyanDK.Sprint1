using Tyuiu.KhanikyanDK.Sprint1.Task5.V5.Lib;
namespace Tyuiu.KhanikyanDK.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.1565;
            int res = ds.Calculate(x);
            Assert.AreEqual(1, res);
        }
    }
}
