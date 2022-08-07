//Напишите программу, которая принимает
//на вход трёхзначное число и на выходе
//показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

System.Console.Clear();

System.Console.WriteLine("Введите своё чило: ");
int number = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine($"Ваше последнее число  {number % 10}");