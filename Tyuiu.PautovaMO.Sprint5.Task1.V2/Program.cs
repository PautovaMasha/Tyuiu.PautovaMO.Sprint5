using System;
using System.IO;
using Tyuiu.PautovaMO.Sprint5.Task1.V2.Lib;

namespace Tyuiu.PautovaMO.Sprint5.Task1.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Паутова М.О. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Паутова Мария Олеговна | ИБКСб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = (2x-3)/(cos(x)-2x) + 5x - 6                         *");
            Console.WriteLine("* Произвести табулирование на диапазоне [-5; 5] с шагом 1.                *");
            Console.WriteLine("* Проверить деление на ноль. При делении на ноль вернуть 0.               *");
            Console.WriteLine("* Результат сохранить в файл и вывести на консоль.                        *");
            Console.WriteLine("* Округлить до двух знаков после запятой.                                 *");            Console.WriteLine(" *                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5, stopValue = 5;
            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона: {stopValue}");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.SaveToFileTextData( startValue,  stopValue);

            Console.WriteLine("Файл:" + result);
            Console.WriteLine("Создан!");


            Console.ReadKey();
        }
    }
}