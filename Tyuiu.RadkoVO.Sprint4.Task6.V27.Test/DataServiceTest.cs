using Tyuiu.RadkoVO.Sprint4.Task6.V27.Lib;

namespace Tyuiu.RadkoVO.Sprint4.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var shapes = new string[]
            {
                "Квадрат", "Прямоугольник", "Круг", "Треугольник",
                "Пятиугольник", "Шестиугольник", "Восьмиугольник"
            };

            int res = ds.Calculate(shapes);
            int wait = 1; // "Квадрат" (6 символов) и "Круг" (4 символа) - меньше 7

            Assert.AreEqual(wait, res);
        }
    }
}
