// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int raw, int col, int min, int max)
{
    int[,] matr = new int[raw,col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}


// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Метод, который проверяет индекс с минимальной суммой элементов
int MinSum(int[,]arr)
{
    int minIndexSum =0;
    int buf = 0;
    int min = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            buf += arr[i,j];
        }
        if (buf<min)
        {
            min=buf;
            minIndexSum=i+1;
        }
        buf=0;
    }
    return minIndexSum;   
}
//метод печати результата
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m,n,0,100);
Print2DArray(matrix);
PrintData("номер строки с наименьшей суммой элементов:", MinSum(matrix));


