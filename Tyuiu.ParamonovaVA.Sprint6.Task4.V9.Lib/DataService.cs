using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ParamonovaVA.Sprint6.Task4.V9.Lib
{
    public class DataService : ISprint6Task4V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];
            int index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Cos(i) - 2 * i == 0)
                {
                    valueArray[index] = 0.0;
                    index++;
                    continue;
                }
                valueArray[index] = Math.Round((2 * i - 3) / (Math.Cos(i) - 2 * i) + 5 * i - Math.Sin(i), 2);
                index++;
            }
            return valueArray;
        }
    }
}