using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PautovaMO.Sprint5.Task5.V11.Lib
{
    public class DataService : ISprint5Task5V11
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            string[] numbers = strX.Split(' ', ',', '\t', '\n', '\r');

            long product = 1;
            bool foundOdd = false;

            foreach (string numStr in numbers)
            {
                if (int.TryParse(numStr, out int num) && num % 2 != 0)
                {
                    product *= num;
                    foundOdd = true;
                }
            }

            if (foundOdd)
            {
                return product;
            }
            else
            {
                return 0;
            }
        }
    }
}
