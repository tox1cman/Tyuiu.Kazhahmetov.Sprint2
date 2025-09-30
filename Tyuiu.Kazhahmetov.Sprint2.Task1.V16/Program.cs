using Tyuiu.Kazhahmetov.Sprint2.Task1.V16.Lib;

DataService ds = new DataService();

int a = 145;
int b = 716;
int c = 144;
int d = 137;

bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.Title = "Спринт #2 | Выполнил: Кажахметов А. Е. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Кажахметов Амир Ерболович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("A:" + a);
Console.WriteLine("B:" + b);
Console.WriteLine("C:" + c);
Console.WriteLine("D:" + d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();