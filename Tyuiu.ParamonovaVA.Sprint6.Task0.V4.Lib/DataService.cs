using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ParamonovaVA.Sprint6.Task0.V4.Lib
{
    public class DataService : ISprint6Task0V4
    {
        public double Calculate(int x)
        {
            double res = 2.4 * Math.Pow((double)x, 3) + 0.4 * Math.Pow((double)x, 2) - 1.4 * (double)x + 4.1;
            return Math.Round(res, 3);
        }
    }
}
