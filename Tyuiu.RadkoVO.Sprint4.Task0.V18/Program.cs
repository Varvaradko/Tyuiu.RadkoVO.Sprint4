using Tyuiu.RadkoVO.Sprint4.Task0.V18.Lib;

namespace Tyuiu.RadkoVO.Sprint4.Task0.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Сумма нечётных элементов массива: ");
            Console.WriteLine();
            Console.WriteLine(ds.GetSumOddArrEl(array));
            Console.ReadKey();

        }
    }
}