using Tyuiu.GaitovaAA.Sprint1.Task0.V0.Lib;

namespace Tyuiu.GaitovaAA.Sprint1.Task0.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
