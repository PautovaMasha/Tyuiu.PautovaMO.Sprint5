using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PautovaMO.Sprint5.Task2.V30.Lib
{
    public class DataService : ISprint5Task2V30
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            string fileContent = "";

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Замена положительных на 1, отрицательных на 0
                    if (matrix[i, j] > 0)
                    {
                        fileContent += "1";
                    }
                    else if (matrix[i, j] < 0)
                    {
                        fileContent += "0";
                    }
                    else
                    {
                        fileContent += "0"; // 0 остается 0
                    }

                    // Добавляем разделитель, если не последний элемент в строке
                    if (j < cols - 1)
                    {
                        fileContent += "; ";
                    }
                }

                // Добавляем перенос строки, если не последняя строка
                if (i < rows - 1)
                {
                    fileContent += "\n";
                }
            }

            File.WriteAllText(path, fileContent.Trim());
            return path;
        }
    }
}
