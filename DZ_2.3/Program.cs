// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 → да, 7 → да, 1 → нет

Console.WriteLine("Для проверки на выходной день введите число от 1 до 7, где 1 - понедельник, а 7 - воскресенье");
int number = int.Parse(Console.ReadLine());

if (number == 1) Console.WriteLine("Понедельник - рабочй день");
if (number == 2) Console.WriteLine("Вторник - рабочй день");
if (number == 3) Console.WriteLine("Среда - рабочй день");
if (number == 4) Console.WriteLine("Четверг - рабочй день");
if (number == 5) Console.WriteLine("Пятница - рабочй день");
if (number == 6) Console.WriteLine("Суббота это выходной день");
if (number == 7) Console.WriteLine("Воскресенье это выходной день");