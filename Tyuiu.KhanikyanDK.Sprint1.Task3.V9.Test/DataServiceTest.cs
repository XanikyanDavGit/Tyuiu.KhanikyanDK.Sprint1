using Tyuiu.KhanikyanDK.Sprint1.Task3.V9.Lib;
namespace Tyuiu.KhanikyanDK.Sprint1.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int minutes = 80;
            double res = ds.ConvertMinutesToHours(minutes);
            Assert.AreEqual(1, res);
        }
    }
}
