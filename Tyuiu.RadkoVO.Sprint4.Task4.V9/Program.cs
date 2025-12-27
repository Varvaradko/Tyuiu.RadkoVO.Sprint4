using Tyuiu.RadkoVO.Sprint4.Task4.V9.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Радько В. О. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8. Найдите сумму четных     *");
Console.WriteLine("* элементов массива.                                                      *");
Console.WriteLine("* 3, 7, 3, 1, 5,                                                          *");
Console.WriteLine("* 6, 3, 2, 1, 2,                                                          *");
Console.WriteLine("* 1, 3, 2, 8, 1,                                                          *");
Console.WriteLine("* 5, 8, 1, 5, 1,                                                          *");
Console.WriteLine("* 3, 3, 4, 4, 6,                                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] mtrx = new int[rows, columns];

Console.WriteLine("Введите элементы массива (от 1 до 8):");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"[{i},{j}] = ");
        mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Массив:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(mtrx[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(mtrx);
Console.WriteLine("Сумма четных элементов массива = " + res);

Console.ReadKey();
