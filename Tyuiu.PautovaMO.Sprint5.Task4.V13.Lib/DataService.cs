using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PautovaMO.Sprint5.Task4.V13.Lib
{
    public class DataService : ISprint5Task4V13
    {
        public double LoadFromDataFile(string path)
        {

            string strX = File.ReadAllText(path);
            // Указываем культуру с точкой как разделителем
            double x = Convert.ToDouble(strX, System.Globalization.CultureInfo.InvariantCulture);
            double res = Math.Round(Math.Cos(x) + (Math.Pow(x, 2) / 2), 3);
            return res;
        }
    }
}
