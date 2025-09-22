using Tyuiu.KhanikyanDK.Sprint1.Task7.V10.Lib;

namespace Tyuiu.KhanikyanDK.Sprint1.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                   ln(cos(x))                                            *");
            Console.WriteLine("* z = 2 * ctg(3x) - -----------                                           *");
            Console.WriteLine("*                   ln(1 + x^2)                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine("Введите текст:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                   *");
            Console.WriteLine("************************************************");

            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    }
}