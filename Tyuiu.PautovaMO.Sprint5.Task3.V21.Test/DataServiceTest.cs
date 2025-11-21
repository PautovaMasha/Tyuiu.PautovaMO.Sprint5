using Tyuiu.PautovaMO.Sprint5.Task3.V21.Lib;
using System.IO;
namespace Tyuiu.PautovaMO.Sprint5.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string createdPath = ds.SaveToFileTextData(3);
            string path = @"C:\Users\Мария\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            File.Delete(path);

        }
    }
}
