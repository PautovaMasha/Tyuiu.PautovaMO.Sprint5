using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.PautovaMO.Sprint5.Task1.V2.Lib
{
    public class DataService : ISprint5Task1V2
    {

        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            string fileContent = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) - 2 * x;
                double result;

                // Проверка деления на ноль
                if (denominator == 0)
                {
                    result = 0;
                }
                else
                {
                    result = ((2 * x - 3) / denominator) + 5 * x - 6;
                }

                result = Math.Round(result, 2);
                fileContent += $"{result}\n";
            }

            File.WriteAllText(path, fileContent.Trim());
            return path;
        }
    }
}