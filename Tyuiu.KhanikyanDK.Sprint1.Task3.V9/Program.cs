using Tyuiu.KhanikyanDK.Sprint1.Task3.V9.Lib;
namespace Tyuiu.KhanikyanDK.Sprint1.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу пересчета величины временного интервала, заданного   *");
            Console.WriteLine("* в минутах, в величину, выраженную в часах и минутах. Ответ округлите до *");
            Console.WriteLine("* 3 знаков после запятой                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();


            Console.WriteLine("Введите временной интервал (в минутах)");
            int minutes = int.Parse(Console.ReadLine() ?? "0");
            int h = minutes / 60;
            int m = minutes % 60;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************+++++++++++++++++++++++++++++++++*+*");
            Console.WriteLine($"{minutes} минут = {h}ч. {m}мин.");

            Console.ReadLine();
        }
    }
}// 150 минут — это 2 ч. 30 мин.