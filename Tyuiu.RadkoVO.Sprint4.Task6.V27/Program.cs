using Tyuiu.RadkoVO.Sprint4.Task6.V27.Lib;

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
Console.WriteLine("* Дан строковый массив данных ['Квадрат','Прямоугольник','Круг',          *");
Console.WriteLine("* 'Треугольник','Пятиугольник','Шестиугольник','Восьмиугольник']          *");
Console.WriteLine("* используя класс Array подсчитайте количество элементов, длина которых   *");
Console.WriteLine("* меньше 7.                                                               *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string[] shapes =
{
    "Квадрат", "Прямоугольник", "Круг", "Треугольник",
    "Пятиугольник", "Шестиугольник", "Восьмиугольник"
};

Console.WriteLine("Исходный массив:");
for (int i = 0; i < shapes.Length; i++)
{
    Console.WriteLine(shapes[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(shapes);
Console.WriteLine("Количество элементов длина которрых < 7 = " + res);

Console.ReadKey();
