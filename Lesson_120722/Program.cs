// 2 Урок от 12.07.2022 Знакомство с языками программирования
//9. Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8
//___________________________________________________________________
//int num = new Random().Next(10, 100); //генерирует число от 10 до 100
//int firstDigit = num / 10; // определяем первую цифру
//int secondDigit = num % 10; // определяем 2 цифру
//if(firstDigit == secondDigit) Console.WriteLine("цифры одиннаковые"); // если цифры совпадают, тогда выводим
//else if(firstDigit > secondDigit) Console.WriteLine($"{num} -> {firstDigit}");
//else Console.WriteLine($"{num} -> {secondDigit}");
//__________________________________________________________________________
// решение задачи с помощью метода
// int MaxDigit(int number) //Методы всегда с большой буквы, а переменные с маленькой
// {
//     int firstDigit = number / 10; // определяем первую цифру
//     int secondDigit = number % 10; // определяем вторую (третью цифру)

//     if (firstDigit == secondDigit) return 0; // если 1 и 2 равны, вернем 0
//     if (firstDigit > secondDigit) return firstDigit; // если 1 > 2 вернем первую
//     return secondDigit;
// }
// int maxDigit = MaxDigit(num);
// if (maxDigit == 0) Console.WriteLine($"{num} -> цифры одиннаковые");
// else Console.WriteLine($"{num} -> {maxDigit}");
//_____________________________________________________________________________________________________
//11 задача, напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 -  46;
// 782 - 72;
// 918 - 98
// int num = new Random().Next(100,1000);
// int num1 = num / 100;
// int num3 = num % 10;
// Console.WriteLine($"{num} -> {num1}{num3}");
//_____________________________________________________________________________________________________
// 12 задача,   34 - 5 не кратно, остаток 4
//              16 - 4, кратно
Console.WriteLine("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1 % 7 == 0 && num1 % 23 == 0) Console.WriteLine($"{num1} -> Кратно");
else Console.WriteLine("Не кратно");




