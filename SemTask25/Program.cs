int ReadData(string number)
{
    Console.WriteLine(number);
    return int.Parse(Console.ReadLine() ?? "0");
}
int exponentiation(int num1, int num2)
{
    int res =1;
    while (num2>0)
    {
        res*=num1;
        num2-=1;
    }
    return res;
}
int number1 = ReadData("Введите 1 число");
int number2 = ReadData("Введите 2 число");
 Console.WriteLine(exponentiation(number1,number2));


