/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)

14212 -> нет

12821 -> да

23432 -> да */

Console.WriteLine("____________________");
Console.WriteLine("Задача 1. Математичиский способ");
Console.WriteLine();
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine()!);
int b1 = (a / 10000);
int b2 = (a / 1000) % 10;
int b3 = (a / 100) % 10;
int b4 = (a / 10) % 10;
int b5 = (a / 1) % 10;

Console.WriteLine();
Console.Write("Ответ: ");

if ((b1 == b5)&&(b2 == b4))
{
    Console.Write($"{a} -> да");
}
else if ((a > 100000)||(a < 1000))
{
    Console.Write($"{a} не пятизначное число. нужно ввести пятизначное число");
}
else
{
    Console.Write($"{a} -> нет");
}

/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* Задача 23



Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("____________________");
Console.WriteLine("Задача 3");
Console.WriteLine();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int a3 = 1;
int result = 0;

Console.WriteLine();
Console.Write("Ответ: ");
while (a3 <= num) 
{
    result = Convert.ToInt32 (Math.Pow(a3, 3));
    Console.Write($"{result}, ");
    a3++;
}
Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
Console.WriteLine("  ");