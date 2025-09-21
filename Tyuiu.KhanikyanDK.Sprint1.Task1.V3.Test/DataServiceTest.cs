using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KhanikyanDK.Sprint1.Task1.V3.Lib;

namespace Tyuiu.KhanikyanDK.Sprint1.Task1.V3.Lib
{
    public class DataServiceTest
    {
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