using Tyuiu.GaitovaAA.Sprint1.Task5.V5.Lib;


namespace Tyuiu.GaitovaAA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int expected = 5;
            
            int actual = ds.Calculate(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
