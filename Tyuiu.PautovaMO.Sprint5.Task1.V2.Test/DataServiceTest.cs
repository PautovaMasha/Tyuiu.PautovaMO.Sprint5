namespace Tyuiu.PautovaMO.Sprint5.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\Users\Мария\source\repos\Tyuiu.PautovaMO.Sprint5\Tyuiu.PautovaMO.Sprint5.Task0.V8\bin\Debug";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
