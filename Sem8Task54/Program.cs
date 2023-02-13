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
//создал метод сортировки одномерного Шелла, больше всех понравился в гугле)
void ShellSort(int[] Array) 
{
    int step = Array.Length / 2;
    while (step > 0)
    {
        int i, j;
        for (i = step; i < Array.Length; i++)
        {
            int value = Array[i];
            for (j = i - step; (j >= 0) && (Array[j] > value); j -= step)
                Array[j + step] = Array[j];
            Array[j + step] = value;
        }
        step /= 2;
    }
}
// метдод который отсортирует двумерный массив c помощью предыдущего метода сортировки одномерного
void Sort2Arr(int[,]arr)
{
    int[] bufA = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            bufA[j] = arr[i,j];
        }
        ShellSort(bufA);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = bufA[j];
        }
    }   
}



int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m,n,0,100);
Print2DArray(matrix);
Sort2Arr(matrix);
Console.WriteLine();
Print2DArray(matrix);