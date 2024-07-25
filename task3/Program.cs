// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


void Main() {
	int arrSize = ReadInt("Введите размер массива: ");
	Random rnd = new Random();
	int[] arr_int = new int[arrSize];

	
	for (int i = 0; i < arrSize; i++) {
		arr_int[i] = rnd.Next(1, 100); 
	}

	PrintArrayInReverse(arr_int, arrSize - 1); 
}

void PrintArrayInReverse(int[] arr, int index) {
	if (index < 0) {
		return;
	}

	Console.Write($"{arr[index]} ");
	PrintArrayInReverse(arr, index - 1);
}

int ReadInt(string msg) {
	Console.Write(msg);
	return Convert.ToInt32(Console.ReadLine());
}

Main();