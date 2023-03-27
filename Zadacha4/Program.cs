// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.WriteLine("Введите первое число");
string per1 = Console.ReadLine();
int num1 = Convert.ToInt32(per1);

Console.WriteLine("Введите второе число");
string per2 = Console.ReadLine();
int num2 = Convert.ToInt32(per2);

Console.WriteLine("Введите третье число");
string per3 = Console.ReadLine();
int num3 = Convert.ToInt32(per3);

int max = num1;

if (num2 > max) max = num2;

else if (num3 > max) max = num3;
Console.WriteLine($"Максимальное число = {max}");