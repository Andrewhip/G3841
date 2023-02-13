int m1 = ReadData("Введите количество строк первой матрицы M1: ");
int n1 = ReadData("Введите количество столбцов первой матрицы N1: ");
int m2 = ReadData("Введите количество строк второй матрицы M2: ");
int n2 = ReadData("Введите количество столбцов второй N2: ");

//проверка на размеры матриц
bool SizeCheck(int[,] arr)
{
    if ((m1 == n1)&&(m2 == n2))
    {
        return true;
    }
    else
    {
        return false; 
    }
}


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

// метод который умножает матрицы
int[,] MultipleMatrix(int[,] matr, int[,] arr)
{
    int[,] matrix = new int[matr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                matrix[i, j] += matr[i, k] * arr[k, j];
            }
        }
    }
    return matrix;
}







int[,] matrix1 = Gen2DArray(m1,n1,0,100);
int[,] matrix2 = Gen2DArray(m2,n2,0,100);

bool size1 =SizeCheck(matrix1);
bool size2 =SizeCheck(matrix2);

Print2DArray(matrix1);
Print2DArray(matrix2);
int[,] mult = MultipleMatrix(matrix1,matrix2);

// тут я уже поплыл и не смог сделать метод, вообще весь код белиберда полная)
//метод который вывод умножение матриц если они равны и наоборот
if (size1 =size2)
{
    Print2DArray(mult);
}
else
{
    Console.WriteLine("Должны быть одинаковые по размеру матрицы");
}




