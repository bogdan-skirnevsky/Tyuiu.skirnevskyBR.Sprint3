using Tyuiu.skirnevskyBR.Sprint3.Task5.V29.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Скирневский Богдан Романович | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #3                                               *");
Console.WriteLine("* Тема: Вложенные циклы                                   *");
Console.WriteLine("* Задание #5                                              *");
Console.WriteLine("* Вариант #29                                             *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1     *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Вычислить двойную сумму по формуле при x = 2:           *");
Console.WriteLine("*     3    10                                             *");
Console.WriteLine("* y = ∑    ∑  (x/k + sin(x))                             *");
Console.WriteLine("*    i=1  k=1                                             *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* x = 2                                                   *");
Console.WriteLine("* i от 1 до 3                                             *");
Console.WriteLine("* k от 1 до 10                                            *");
Console.WriteLine("***********************************************************");

int x = 2;
int startValue1 = 1;
int startValue2 = 1;
int stopValue1 = 3;
int stopValue2 = 10;

Console.WriteLine("Переменная X =" + x);
Console.WriteLine("Старт шага первой суммы ряда =" + startValue1);
Console.WriteLine("Конец шага первой суммы ряда =" + startValue2);
Console.WriteLine("Старт шага второй суммы ряда =" + stopValue1);
Console.WriteLine("Конец шага второй суммы ряда =" + stopValue2);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");


Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
Console.ReadKey();
