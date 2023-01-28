int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int SumNumbers(int num)
{
     int res = 0;
     while (num != 0)
     {
         res += num%10;
         num/=10;
     }
     return res;
 }


int number = ReadData("Введите число:");
int sum = SumNumbers(number);

PrintData("Сумма чисел равна: ", sum);