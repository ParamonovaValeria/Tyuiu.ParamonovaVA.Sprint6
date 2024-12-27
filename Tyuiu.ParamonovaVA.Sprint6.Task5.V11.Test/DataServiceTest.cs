using Tyuiu.ParamonovaVA.Sprint6.Task5.V11.Lib;

namespace Tyuiu.ParamonovaVA.Sprint6.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Дети\source\repos\Tyuiu.ParamonovaVA.Sprint6\DataSprint6\InPutDataFileTask5V11.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}