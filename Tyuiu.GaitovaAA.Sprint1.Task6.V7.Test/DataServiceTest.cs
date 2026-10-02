using Tyuiu.GaitovaAA.Sprint1.Task6.V7.Lib;

namespace Tyuiu.GaitovaAA.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string str = "Привет милая пузяка";
            string expected = "Приве мила пузяк";

            string res = ds.DeleteLastLetter(str);

            Assert.AreEqual(expected, res);
        }
    }
}
