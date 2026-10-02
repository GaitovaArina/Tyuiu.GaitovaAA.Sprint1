using Tyuiu.GaitovaAA.Sprint1.Task2.V3.Lib;

namespace Tyuiu.GaitovaAA.Sprint1.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int hours = 2;
            var res = ds.ConvertHourToMin(hours);
            Assert.AreEqual(120, res);
        }
    }
}
