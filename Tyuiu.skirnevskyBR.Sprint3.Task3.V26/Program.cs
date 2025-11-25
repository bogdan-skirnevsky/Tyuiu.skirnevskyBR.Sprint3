using Tyuiu.skirnevskyBR.Sprint3.Task3.V26.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Скирневский Богдан Романович | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #3                                               *");
Console.WriteLine("* Тема: Работа со строками и цикл foreach                 *");
Console.WriteLine("* Задание #3                                              *");
Console.WriteLine("* Вариант #26                                             *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1     *");
Console.WriteLine("***********************************************************");

string value = "have a nice time";
char item = 'e';
int result = ds.GetCharCount(value, item);

Console.WriteLine($"Количество букв 'e' в строке: {result}");
Console.ReadLine();
