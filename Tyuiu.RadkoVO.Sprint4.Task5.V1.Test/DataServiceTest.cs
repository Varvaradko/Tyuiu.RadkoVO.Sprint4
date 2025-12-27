using Tyuiu.RadkoVO.Sprint4.Task5.V1.Lib;

namespace Tyuiu.RadkoVO.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]
            {
                { -1,  2,  3, -4,  5 },
                {  6, -7,  8,  9, -1 },
                {  2,  3, -2, -3,  7 },
                { -4,  5, -6,  7, -8 },
                {  1, -1,  2,  3, -2 }
            };

            int[,] wait = new int[5, 5]
            {
                { -1,  1,  1, -4,  1 }, // Положительные: 2,3,5 → 1
                {  1, -7,  1,  1, -1 }, // Положительные: 6,8,9 → 1
                {  1,  1, -2, -3,  1 }, // Положительные: 2,3,7 → 1
                { -4,  1, -6,  1, -8 }, // Положительные: 5,7 → 1
                {  1, -1,  1,  1, -2 }  // Положительные: 1,2,3 → 1
            };

            int[,] res = ds.Calculate(mas2);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
