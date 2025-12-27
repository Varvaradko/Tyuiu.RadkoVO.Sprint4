using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RadkoVO.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.GetUpperBound(1) + 1;
            int min = array[0, columns - 1]; // Инициализируем первым элементом последнего столбца

            for (int i = 1; i < rows; i++)
            {
                if (array[i, columns - 1] < min)
                {
                    min = array[i, columns - 1];
                }
            }

            return min;
        }
    }
}
