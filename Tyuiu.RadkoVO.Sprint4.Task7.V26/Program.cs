using Tyuiu.RadkoVO.Sprint4.Task7.V26.Lib;

int rows = 5;
int columns = 3;
string str = "351268459614723";
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
Console.WriteLine("* Дана строка из одноразрядных цифр '351268459614723'. Преобразуйте       *");
Console.WriteLine("* ее в матрицу 5 на 3 и подсчитайте произведение четных чисел.            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("\nМатрица 5x3:");
int index = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{str[index]} \t");
        index++;
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(rows, columns, str);

Console.WriteLine("Произведение чётных элементов = " + res);

Console.ReadKey();
