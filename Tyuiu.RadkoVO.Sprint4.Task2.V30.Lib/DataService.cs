using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RadkoVO.Sprint4.Task2.V30.Lib
{
    public class DataService : ISprint4Task2V30
    {
        public int Calculate(int[] array)
        {
            int product = 1; // Инициализируем 1 для умножения
            bool hasOdd = false; // Флаг, есть ли нечётные элементы

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    product *= array[i];
                    hasOdd = true;
                }
            }

            // Если нечётных элементов не было, возвращаем 0
            // Или можно вернуть 1, в зависимости от требований задачи
            return hasOdd ? product : 0;
        }
    }
}
