// урок 08.07.2022
// Демонстрация решения
// 1/ Напишите программу, которая на вход
// 2. принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = num * num;
Console.WriteLine($"Квадрат числа {num} = {res}");

//int a = 4,
//    b = - 3,
//    c = - 7;

//Console.WriteLine(a*a);
//Console.WriteLine(b*b);
//Console.WriteLine(c*c);

//int  num = 4;
//double d = 4.6;
//int res = num * num;
//Console.WriteLine(res);

// Task 2
//1. Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

//int num = Convert.ToInt32(Console.ReadLine());
//int num2  = Convert.ToInt32(Console.ReadLine());
int a=25, b=5;

if(a == b * b);
    {
    Console. Write(true);
    }

Console.Write("Write a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;

if (n < 0)
{
     i = n;
    n = n * -1;
}
else
{
   i = -n;
}

while (i <= n)
{
    Console.WriteLine(i);
    i++;
}

