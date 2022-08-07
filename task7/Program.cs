//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли второе число
//кратным первому. Если число 2 не кратно числу 1, то
//программа выводит остаток от деление.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

System.Console.Clear();

System.Console.WriteLine("Введите первое число");
double firstNumber = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите второе число");
double secondNumber = double.Parse(System.Console.ReadLine()!);

if (firstNumber % secondNumber == 0) 
    System.Console.WriteLine("Первое число кратно второму");
else 
    System.Console.WriteLine($"Остаток от деления {firstNumber % secondNumber:f3}");
