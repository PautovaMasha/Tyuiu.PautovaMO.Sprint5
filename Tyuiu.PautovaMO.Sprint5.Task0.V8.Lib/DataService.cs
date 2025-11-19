using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.PautovaMO.Sprint5.Task0.V8.Lib
{
    public class DataService : ISprint5Task0V8
    {

        public string SaveToFileTextData(int x)
        {
            double result = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
            double z = Math.Round(result, 3);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}