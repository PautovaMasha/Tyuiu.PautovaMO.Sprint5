using Tyuiu.PautovaMO.Sprint5.Task2.V30.Lib;
using System.IO;
namespace Tyuiu.PautovaMO.Sprint5.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\Мария\source\repos\Tyuiu.PautovaMO.Sprint5\Tyuiu.PautovaMO.Sprint5.Task0.V8\bin\Debug\OutPutFileTask2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
