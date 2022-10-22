
int ThirdDigitOFnumber(int a)
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
