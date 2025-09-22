using Tyuiu.KhanikyanDK.Sprint1.Task4.V12.Lib;
namespace Tyuiu.KhanikyanDK.Sprint1.Task4.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* вычисляет результат по формуле (sin(PI*x))/(x+sqrt(|y|)) и печатает     *");
            Console.WriteLine("* его на экране. Ответ округлите до 3 знаков после запятой                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
             
            DataService ds = new DataService();


            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Введите y");
            double y = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************+++++++++++++++++++++++++++++++++*+*");
            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}