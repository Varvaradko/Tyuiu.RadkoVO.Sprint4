using Tyuiu.RadkoVO.Sprint4.Task1.V18.Lib;

namespace Tyuiu.RadkoVO.Sprint4.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int len;
            Console.Write("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write("Введите значение элемента под номером " + i + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Результат: ");
            Console.WriteLine(ds.Calculate(array));
            Console.ReadKey();

        }
    }
}
