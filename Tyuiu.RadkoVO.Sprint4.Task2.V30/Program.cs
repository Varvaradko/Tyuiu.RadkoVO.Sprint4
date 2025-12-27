using Tyuiu.RadkoVO.Sprint4.Task2.V30.Lib;

DataService ds = new DataService();
Random rnd = new Random();

Console.Title = "Спринт #4 | Выполнила: Радько В. О. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
Console.WriteLine("* случайными в диапазоне от 2 до 8. Подсчитать сумму нечетных             *");
Console.WriteLine("* элементов массива.                                                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];

for (int i = 0; i < len; i++)
{
    numsArray[i] = rnd.Next(2, 10);
}

Console.WriteLine("Массив:");
for (int i = 0; i < len; i++)
{
    Console.Write(numsArray[i] + "\t");
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(numsArray);

Console.WriteLine("Сумма нечётных элементов массива = " + res);
Console.ReadKey();
