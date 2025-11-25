using Tyuiu.skirnevskyBR.Sprint3.Task7.V23.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Скирневский Богдан Романович | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #3                                               *");
Console.WriteLine("* Тема: Табулирование функции                             *");
Console.WriteLine("* Задание #7                                              *");
Console.WriteLine("* Вариант #23                                             *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1     *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений    *");
Console.WriteLine("* функции: F(x) = 4 - 2x + (2+cos(x))/(2x-2)              *");
Console.WriteLine("* на диапазоне [-5; 5] с шагом 1.                         *");
Console.WriteLine("* При делении на ноль вернуть значение 0.                 *");
Console.WriteLine("* Значения округлить до двух знаков после запятой.        *");
Console.WriteLine("* Значения занести в массив!                              *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* Диапазон: [-5; 5]                                       *");
Console.WriteLine("* Шаг: 1                                                   *");
Console.WriteLine("* Функция: F(x) = 4 - 2x + (2+cos(x))/(2x-2)              *");
Console.WriteLine("***********************************************************");

int startValue = -5;
int stopValue = 5;

double[] resultArray = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("+----------+-----------+");
Console.WriteLine("|    x     |   F(x)    |");
Console.WriteLine("+----------+-----------+");

for (int i = 0, x = startValue; x <= stopValue; i++, x++)
{
    Console.WriteLine($"| {x,5}    | {resultArray[i],8:F2}  |");
}

Console.WriteLine("+----------+-----------+");

Console.WriteLine("\nМассив значений:");
Console.Write("[");
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i].ToString("F2"));
    if (i < resultArray.Length - 1)
        Console.Write(", ");
}
Console.WriteLine("]");

Console.ReadLine();
