using Tyuiu.skirnevskyBR.Sprint3.Task6.V9.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Скирневский Богдан Романович | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #3                                               *");
Console.WriteLine("* Тема: Алгоритмы циклической структуры                   *");
Console.WriteLine("* Задание #6                                              *");
Console.WriteLine("* Вариант #9                                              *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1     *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,     *");
Console.WriteLine("* принадлежащих числовому отрезку [19, 30] количество     *");
Console.WriteLine("* всех делителей (сумму количеств делителей всех чисел)   *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* Диапазон чисел: [19, 30]                                *");
Console.WriteLine("***********************************************************");

int startValue = 19;
int stopValue = 30;

Console.WriteLine("Начало отрезка =" + startValue);
Console.WriteLine("Конец отрезка =" + stopValue);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Сумма делителей " + ds.GetSumTheDivisors(startValue, stopValue));
Console.ReadKey();