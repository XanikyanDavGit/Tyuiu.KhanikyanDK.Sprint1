using Tyuiu.KhanikyanDK.Sprint1.Task3.V9.Lib;
namespace Tyuiu.KhanikyanDK.Sprint1.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression(int minutes)
        {
            DataService ds = new DataService();
            float res = ds.ConvertMinutesToHours(minutes);
            Assert.AreEqual(1.333, res);
        }
    }
}
