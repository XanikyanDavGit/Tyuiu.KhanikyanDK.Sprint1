using Tyuiu.KhanikyanDK.Sprint1.Task4.V12.Lib;
namespace Tyuiu.KhanikyanDK.Sprint1.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 0.9;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0, res); 
        }
    }
}
