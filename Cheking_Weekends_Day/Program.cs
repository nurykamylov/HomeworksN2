/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/


Console.Write("Type  number: ");
int a  = int.Parse(Console.ReadLine()!);

if ( a == 6 || a == 7)
{
    Console.WriteLine("yep!");
}

else if (a == new Random().Next(1, 6) )
{
    Console.WriteLine("no!");
}
else
{
  Console.WriteLine("Please, type the number in (1,7) range! ");
}