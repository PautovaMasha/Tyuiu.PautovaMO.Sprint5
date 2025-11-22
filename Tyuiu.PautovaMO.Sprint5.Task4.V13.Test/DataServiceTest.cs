using Tyuiu.PautovaMO.Sprint5.Task4.V13.Lib;
using System.IO;
namespace Tyuiu.PautovaMO.Sprint5.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\DataSprint5\InPutDataFileTask4V13.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            File.Delete(path);
        }
    }
}
