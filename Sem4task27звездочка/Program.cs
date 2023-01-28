string ReadData(string msg)
{
    Console.WriteLine(msg);
    return (Console.ReadLine() ?? "0");
}

void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

string SumNumbers(string num)
{
    int total = 0;
    for (int i = 0; i < num.ToString().Length; i++)
    {
        int numbers = int.Parse(num);
        total += (num[i] - 48);

    }
    return total.ToString();
}

string number = ReadData("Введите число:");
string sum = SumNumbers(number);

PrintData("Сумма чисел равна: ", sum);





