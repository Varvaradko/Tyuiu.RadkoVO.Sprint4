using Tyuiu.RadkoVO.Sprint4.Task0.V18.Lib;

namespace Tyuiu.RadkoVO.Sprint4.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };//

            int wait = 41;
            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }
    }
}
