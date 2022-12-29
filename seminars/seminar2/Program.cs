/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
/*Console.WriteLine("Введите трёхзначное число");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1000 && x > 99)
{
int two = x / 10;
int result = two % 10;
Console.Write(result);
}
else
Console.Write("Ввели не трёхзначное число ");*/
/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
/*Console.WriteLine ("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 100)
{
Console.Write("Третьей цифры нет");
}
else
{
while (x >= 1000)    
{
    x = x / 10;
}
if (x < 1000)
{
int three = x % 100;
int tow = three % 10;
Console.Write(tow);
}
}*/
/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
/*Console.WriteLine ("Введите цифру дня недели");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 0 && x < 6)
{
Console.Write("Нет");
}
if (x > 5 && x < 8)
{
Console.Write("Да");
}
if (x < 1 || x > 7)
{
Console.Write("Ввели не корректный день недели");
}*/





