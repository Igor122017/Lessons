// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.Clear(); // очистка терминала
Console.WriteLine("Введите трехзначное число: "); // запрашивает 3 числа
int numberOne = Convert.ToInt32(Console.ReadLine()); // поле для ввода
double SecondDigit(int number) //присваеваем 2 числу переменную
{
	double resultSecond = 1; // присваеваем в случае, ввода меньше 3 чисел
	if (number < 100 || number > 999) // проверка на ввод 3 числе
	{
		Console.WriteLine("Error: Введите трехзначное число"); // вывод в случае, если ввел меньше 
	}
	else{
		double result = number / 10; //сдвигаемся ко 2 целому числучислу
		resultSecond = Math.Round(result, 1) % 10; 
	}
	return resultSecond; // возвращаем нужное число
}
Console.WriteLine(SecondDigit(numberOne)); // выводим второе число