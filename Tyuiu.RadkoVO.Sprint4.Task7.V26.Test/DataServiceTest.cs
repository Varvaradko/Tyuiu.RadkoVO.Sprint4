using Tyuiu.RadkoVO.Sprint4.Task7.V26.Lib;

namespace Tyuiu.RadkoVO.Sprint4.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 5;
            int columns = 3;
            string str = "351268459614723";

            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);

            int wait = 18432; 
            Assert.AreEqual(wait, res);
        }
    }
}
