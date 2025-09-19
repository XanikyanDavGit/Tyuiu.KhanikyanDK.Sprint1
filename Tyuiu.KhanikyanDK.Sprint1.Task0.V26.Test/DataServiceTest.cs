using Tyuiu.KhanikyanDK.Sprint1.Task0.V26.Lib;
namespace Tyuiu.KhanikyanDK.Sprint1.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        
              public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.75, res);
        }
    }
    }

