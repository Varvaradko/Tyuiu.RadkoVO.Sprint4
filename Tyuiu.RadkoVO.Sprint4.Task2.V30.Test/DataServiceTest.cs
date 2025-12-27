using Tyuiu.RadkoVO.Sprint4.Task2.V30.Lib;

namespace Tyuiu.RadkoVO.Sprint4.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 0, 3, 12, 11 };
            int res = ds.Calculate(numsArray);
            int wait = 14;

            Assert.AreEqual(wait, res);
        }
    }
}
