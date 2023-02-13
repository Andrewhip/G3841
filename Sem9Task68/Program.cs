// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

int Ackerfunct(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Ackerfunct(n - 1, 1);
    if (n > 0 && m > 0) return Ackerfunct(n - 1, Ackerfunct(n, m - 1));
    return Ackerfunct(n,m);
}

int n = ReadData("Введите первое число: ");
int m = ReadData("Введите второе число: ");
PrintResult(Ackerfunct(n,m));