using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PautovaMO.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r', '(', ')', '[', ']', '{', '}', '"', '-' };
            string[] words = strX.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words.Count(w => w.Length == 6);
        }
    }
}
