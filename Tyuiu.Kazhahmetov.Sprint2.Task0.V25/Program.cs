using Tyuiu.Kazhahmetov.Sprint2.Task0.Lib;

DataService ds = new DataService();

int x = 205;
int y = 159;

bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.Title = "Спринт #2 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");                                            
Console.WriteLine("***************************************************************************");

Console.WriteLine("X:" + x);
Console.WriteLine("Y:" + y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();
