
using System.IO;
namespace Tyuiu.PautovaMO.Sprint5.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\DataSprint5\InPutDataFileTask7V29.txt"; 
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
