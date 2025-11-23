using Tyuiu.PautovaMO.Sprint5.Task5.V11.Lib;
using System.IO;
namespace Tyuiu.PautovaMO.Sprint5.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V11.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            File.Delete(path);
        }
    }
}
