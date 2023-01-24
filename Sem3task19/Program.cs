int ReadData(string msg)                   // Создал метод который читает данные от пользователя
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(bool msg)     //Выводим результат пользователю
{
    Console.WriteLine(msg);
}


bool Palintest(int n)     //метод который проверяет является ли число палиндромом
{
    
        
    bool res = false;
    int d1 = (n / 10000);
    int d2 = (n / 1000) % 10;
    int d3 = (n / 10) % 10;
    int d4 = n % 10;
    res = (d1 == d4) && (d2 == d3) ? true : false;
    return res;
    
}


int num = ReadData("введите число");   // Ввод данных
bool palindrome = Palintest(num);
PrintData(palindrome);  // Вывод данных