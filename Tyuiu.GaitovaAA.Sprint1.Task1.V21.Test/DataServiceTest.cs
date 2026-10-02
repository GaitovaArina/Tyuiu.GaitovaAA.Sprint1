using Tyuiu.GaitovaAA.Sprint1.Task1.V21.Lib;

namespace Tyuiu.GaitovaAA.Sprint1.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.5, res);
        }
    }
}
