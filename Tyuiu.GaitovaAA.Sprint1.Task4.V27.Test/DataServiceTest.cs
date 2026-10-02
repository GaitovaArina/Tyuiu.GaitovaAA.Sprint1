using Tyuiu.GaitovaAA.Sprint1.Task4.V27.Lib;

namespace Tyuiu.GaitovaAA.Sprint1.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 9.0;
            double wait = -1.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
