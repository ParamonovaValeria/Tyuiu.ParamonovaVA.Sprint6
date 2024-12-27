using Tyuiu.ParamonovaVA.Sprint6.Task4.V9.Lib;

namespace Tyuiu.ParamonovaVA.Sprint6.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            double[] wait = new double[]
            {
                -27.22,
                -22.25,
                -16.66,
                -11.04,
                -6.13,
                -3.0,
                 4.84,
                 8.86,
                 14.43,
                20.18,
                25.24
            };
            CollectionAssert.AreEqual(wait, dataService.GetMassFunction(-5, 5));
        }
    }
}