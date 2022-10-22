
/*Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
int ThirdDigitOFnumber(int a)*/


{
    while(a >= 1000){
    a = a /10;
    }
     
    return a % 10;
}
    
Console.Write("Type any number: ");
int a  = int.Parse(Console.ReadLine()!);

if ( a >= 1000)
{
    Console.WriteLine(ThirdDigitOFnumber(a));
}
 else if  (a < 100)
{
    Console.WriteLine("there isn't third digit");
}
else 
{
 Console.WriteLine(a % 10);
}
