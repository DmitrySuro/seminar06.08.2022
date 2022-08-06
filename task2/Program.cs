 //Напишите программу, которая на вход принимает 
 //два числа и проверяет, является ли второе число квадратом первого.
//a = 5, b = 25 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> нет 
//a = -3, b = 9 -> да
System.Console.Clear();

System.Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA * numberA == numberB )
{
    System.Console.WriteLine("yes"); 
}
else
{
    System.Console.WriteLine("no");
}

