// Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

System.Console.Clear();

Random rnd = new Random();
int number = rnd.Next(10,100);

int firstNumber = number / 10;
int secondNumber = number % 10;

System.Console.Write($"Наибольшая цифра числа {number} : ");
if (firstNumber > secondNumber) 
    System.Console.WriteLine(firstNumber);
else 
    System.Console.WriteLine(secondNumber);
