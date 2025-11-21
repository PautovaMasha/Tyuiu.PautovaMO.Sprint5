using System;
using System.IO;
using Tyuiu.PautovaMO.Sprint5.Task3.V21.Lib;

namespace Tyuiu.PautovaMO.Sprint5.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Паутова М.О. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с бинарными файлами                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Паутова Мария Олеговна | ИБКСб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение B(x) = (x² + 1) / √(4 * x² - 3)                          *");
            Console.WriteLine("* Вычислить значение при x = 3, результат сохранить в бинарный файл       *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");



            string result = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл:" + result);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}