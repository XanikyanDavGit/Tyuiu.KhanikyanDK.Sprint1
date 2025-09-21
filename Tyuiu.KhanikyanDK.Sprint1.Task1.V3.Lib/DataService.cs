using tyuiu.cources.programming.interfaces.Sprint1; //dll
namespace Tyuiu.KhanikyanDK.Sprint1.Task1.V3.Lib
{
    public class DataService : ISprint1Task1V3
    {
        public double Calculate(double x, double y)
        {
            return (x - y) / (x + 3) + 3;
        }
    }
} 