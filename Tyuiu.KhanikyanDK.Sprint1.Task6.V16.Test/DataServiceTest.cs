using Tyuiu.KhanikyanDK.Sprint1.Task6.V16.Lib;
namespace Tyuiu.KhanikyanDK.Sprint1.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string a = "hasd  !?ahda";
            bool res = ds.CheckSpecSymbols(a);
            Assert.AreEqual(true, res);
        }
    }
}
