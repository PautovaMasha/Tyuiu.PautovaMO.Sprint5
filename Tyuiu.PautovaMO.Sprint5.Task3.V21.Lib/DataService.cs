using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PautovaMO.Sprint5.Task3.V21.Lib
{
    public class DataService : ISprint5Task3V21
    {
        public string SaveToFileTextData(int x)
        {
            double numer = Math.Pow(x, 2) + 1;
            double minator = Math.Sqrt(4 * Math.Pow(x, 2) - 3);

            double result = numer / minator;
            result = Math.Round(result, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(result);
            }

            return path;
        }
    }
}
