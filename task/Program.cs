//Напишите программу, которая на вход принимает число
// и выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine("Введите число");
int numbers = int.Parse(Console.ReadLine());

int sqr = numbers * numbers;

System.Console.WriteLine(sqr);

double sqr2 = Math.Pow(numbers, 2);

System.Console.WriteLine($"Квадрат числа {numbers} равен - {sqr2}");