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
int RecMN(int m, int n)
{
    if (m >= n) return n;
    return m + RecMN(m + 1, n);
}

int m = ReadData("Введите первое число: ");
int n = ReadData("Введите второе число: ");

PrintResult(m > n ? RecMN(n, m) : RecMN(m, n));
