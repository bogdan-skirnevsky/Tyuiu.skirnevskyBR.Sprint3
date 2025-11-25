using Tyuiu.skirnevskyBR.Sprint3.Task4.V10.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #3| Выполнил: Скирневский Б.Р. | ИБКСБ-25-1";
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #3                                        *");
Console.WriteLine("* Тема:Использование операторов Continue и break   *");
Console.WriteLine("* в циклах                                         *");
Console.WriteLine("* Задание #4                                       *");
Console.WriteLine("* Вариант #10                                      *");
Console.WriteLine("* Выполнил: Скирневский Б.Р. | ИБКСБ-25-1          *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, *");
Console.WriteLine("*  вычислить значение функции y=(sin(x)-x)/x       *");
Console.WriteLine("* При х = 0 пропустить значение Полученные значения*");
Console.WriteLine("* перемножить.                                     *");

Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");
int startValue = -5;
int stopValue = 5;

Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));
Console.ReadKey();