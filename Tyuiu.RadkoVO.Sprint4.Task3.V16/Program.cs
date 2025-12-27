using Tyuiu.RadkoVO.Sprint4.Task3.V16.Lib;

DataService ds = new DataService();

int[,] array = new int[5, 5]
{
    { 5, 8, 5, 8, 4 },
    { 2, 3, 4, 6, 3 },
    { 1, 1, 2, 9, 9 },
    { 6, 7, 4, 1, 2 },
    { 5, 7, 1, 8, 7 }
};

int rows = array.GetLength(0);
int columns = array.GetLength(1);

Console.Title = "Спринт #4 | Выполнила: Радько В. О. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 1 до 9. Найдите минимальный      *");
Console.WriteLine("* элемент в последнем столбце массива.                                    *");
Console.WriteLine("* 5, 8, 5, 8, 4,                                                          *");
Console.WriteLine("* 2, 3, 4, 6, 3,                                                          *");
Console.WriteLine("* 1, 1, 2, 9, 9,                                                          *");
Console.WriteLine("* 6, 7, 4, 1, 2,                                                          *");
Console.WriteLine("* 5, 7, 1, 8, 7,                                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(array);
Console.WriteLine("Минимальный элемент последнего столбца = " + res);

Console.ReadKey();

