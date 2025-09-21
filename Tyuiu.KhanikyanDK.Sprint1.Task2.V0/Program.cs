using Tyuiu.KhanikyanDK.Sprint1.Task2.V22.Lib;
namespace Tyuiu.KhanikyanDK.Sprint1.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу которая запрашивает у пользователя 3 числа и         *");
            Console.WriteLine("* вычисляет среднее ариметическое и печатает результат на экране          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int valueOne, valueTwo, valueThree;

            Console.WriteLine("Введите первое число:");
            valueOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            valueTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            valueThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("среднее ариметическое: " + ds.CalculateAVGValue(valueOne, valueTwo, valueThree));

            Console.ReadLine();
        }
    }
}