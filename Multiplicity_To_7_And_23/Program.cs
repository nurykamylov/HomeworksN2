/*Дополнительная Задача 9
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

Console.Write("Type any number: ");
int a  = int.Parse(Console.ReadLine()!);

if (a % (7 * 23) == 0)
{
    Console.WriteLine("yep!");
}
else 
{
    Console.WriteLine("no!");
}
