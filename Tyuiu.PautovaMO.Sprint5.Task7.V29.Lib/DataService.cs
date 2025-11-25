using System.Text.RegularExpressions;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PautovaMO.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V29.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists= fileInfo.Exists;

            
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Удаляем все однозначные числа из текущей строки
                    strLine = Regex.Replace(line, @"\b\d\b", "");

                    // Записываем обработанную строку в файл
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }

            return pathSaveFile;
        }
    }
}
