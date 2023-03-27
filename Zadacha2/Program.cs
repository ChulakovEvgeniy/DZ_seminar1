//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
string per1 = Console.ReadLine();
int num1 = Convert.ToInt32(per1);

Console.WriteLine("Введите второе число");
string per2 = Console.ReadLine();
int num2 = Convert.ToInt32(per2);

if (num1 > num2) Console.WriteLine($"(Первое число = {num1}) > (второе число = {num2})");

else
{
    Console.WriteLine($"(Второе число = {num2}) > (первое число = {num1})");
}