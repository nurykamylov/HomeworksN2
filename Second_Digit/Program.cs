
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int SecondDigitOfNumber(int a )
{
    int b = a /10  % 10;
    
    return b;
}
Console.Write("Type the  triple number: ");
int a  = int.Parse(Console.ReadLine()!);
 Console.WriteLine(SecondDigitOfNumber(a));