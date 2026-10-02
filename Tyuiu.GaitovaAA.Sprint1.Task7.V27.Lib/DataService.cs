using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GaitovaAA.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double numerator1 = Math.Cos(Math.Pow(x, 2)) + Math.Sin(Math.Pow(y, 2));
            double denominator1 = Math.Sin(y) + 1;

            double numerator2 = (x * y) - 12;
            double denominator2 = 15 + Math.Cos(x);

            double result = (numerator1 / denominator1) - (numerator2 / denominator2);

            return Math.Round(result, 3);
        }
    }
}