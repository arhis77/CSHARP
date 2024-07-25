// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Main() {
	int number1 = ReadInt("Введите певрое число: ");
	int number2 = ReadInt("Введите второе число: ");

	if (number1 < 1 || number2 < 1) {
		Console.WriteLine("Пожалуйста, введите натуральные числа (больше 0).");
	}
	else if (number1 > number2) {
		 Console.WriteLine("N должно быть меньше или равно M");
	}
	else {
		PrintNumber(number1, number2);
	}
	
}

void PrintNumber(int N, int M) {
	if (N > M) return;

	  if (N == M) {
		Console.Write(N);
	} else {
		System.Console.Write(N + ", ");
	}
	PrintNumber(N + 1, M);
}

int ReadInt(string msg) {
	System.Console.Write(msg);
	return Convert.ToInt32(Console.ReadLine());
}

Main();