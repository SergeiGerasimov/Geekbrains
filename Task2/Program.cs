//  Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите  число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 == 1)
{
    Console.Write("Понедельник");
}
else
if (num1 == 2)
{
    Console.Write("Вторник");
}
else
if (num1 == 3)
{
    Console.Write("Среда");
}
else
if (num1 == 4)
{
    Console.Write("Четверг");
}
else
if (num1 == 5)
{
    Console.Write("Пятница");
}
else
if (num1 == 6)
{
    Console.Write("Суббота");
}
else
if (num1 == 7)
{
    Console.Write("Воскресенье");
}
else
{
    Console.Write("Такого дня недели нет");
}