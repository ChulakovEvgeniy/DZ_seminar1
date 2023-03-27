Console.Clear();
Console.Write("Введите число = ");
string per = Console.ReadLine();
int num = Convert.ToInt32(per);

if (num % 2 == 0) {Console.WriteLine ($"Число {num} четное");}
else {
    Console.WriteLine ($"Число {num} нечетное");
}