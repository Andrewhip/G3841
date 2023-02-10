//1) Получение данных от пользователя
int n = InputNum("Количество строк матрицы");
int m = InputNum("Количество строк матрицы");

//2) Генерация двумерного массива
double[,] matix = FillTwoDimArray(n,m);

//3) Печатаем двумерный массив
PrintTwoDimArray(matix);


int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    double[,] outArray = new double[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(countRow, countColumn)+ numberSyntezator.NextDouble();
            outArray[i, j] =Math.Round(outArray[i,j],2);   //тут сделал так чтобы после запятой было 2 цифры
            j++;
        }
        i++;
    }
    return outArray;
}


//метод для печати двумерного массива
void PrintTwoDimArray(double[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor(); 
            j++;
        }
        
        Console.WriteLine();
        i++;
    }
}