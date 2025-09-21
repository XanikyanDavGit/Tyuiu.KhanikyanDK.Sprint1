using Tyuiu.KhanikyanDK.Sprint1.Task2.V22.Lib;
namespace Tyuiu.KhanikyanDK.Sprint1.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 7;
            int z = 2; 
            int res = ds.CalculateAVGValue(x, y, z);
            Assert.AreEqual(3, res);
        }
    }
}