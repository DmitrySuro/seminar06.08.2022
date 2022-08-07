// Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

System.Console.Clear();

Random rnd = new Random();
int number = rnd.Next(10,99);

int firstNumber = number / 10;
int twoNumber = number % 10;

if (firstNumber > twoNumber) System.Console.WriteLine($"Наибольшая цифра этого числа: {firstNumber}");
if (firstNumber < twoNumber) System.Console.WriteLine($"Наибольшая цифра этого числа: {twoNumber}");

System.Console.WriteLine(number);