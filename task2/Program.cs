void Main() {
	int n = ReadInt("Введите певрое число: ");
	int m = ReadInt("Введите второе число: ");
	Console.Write(Ack (n, m));
}

int Ack (int n, int m) {
	if (n == 0) {
		return m + 1;
	} else if (m == 0) {
		return Ack (n - 1,1);
	} else {
		return Ack (n - 1, Ack (n, m - 1));
	}
}

int ReadInt(string msg) {
	System.Console.Write(msg);
	return Convert.ToInt32(Console.ReadLine());
}

Main();