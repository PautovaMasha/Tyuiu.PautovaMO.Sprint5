using Tyuiu.PautovaMO.Sprint5.Task6.V20.Lib;
using System.IO;
namespace Tyuiu.PautovaMO.Sprint5.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
       
            public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V11.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V20.txt");

            // Создаём тестовый файл с известным количеством слов длиной 6
            string testData = "hello world python output result stream";
            File.WriteAllText(path, testData);

            int res = ds.LoadFromDataFile(path);
            int wait = 4; // python, output, result, stream

            Assert.AreEqual(wait, res);

            File.Delete(path);
        }
    
    }
}
