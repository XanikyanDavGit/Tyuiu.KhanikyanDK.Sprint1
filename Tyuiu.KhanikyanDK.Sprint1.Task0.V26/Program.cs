
using Tyuiu.KhanikyanDK.Sprint1.Task0.V26.Lib;
Console.Title = "Спринт #1 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #3                                                             *");
Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу которая вычисляет выражение 4 * 5 / 2 - 18 / 2 / 3   *");
Console.WriteLine("* и печатает результат на экране                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* 4 * 5 / 2 - 18 / 2 / 3                                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
// Метод Calculate находится в библиотеке Tyuiu.KhanikyanDK.Sprint1.Task0.V0.Lib 
// в классе DataService
DataService ds = new DataService();
Console.WriteLine(ds.Calculate());
Console.ReadLine();
