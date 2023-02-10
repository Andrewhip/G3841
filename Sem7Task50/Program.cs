
//1) Получение данных от пользователя
int n = InputNum("Количество строк матрицы");
int m = InputNum("Количество строк матрицы");
int num = InputNum("введите нужное число в матрице");


//2) Генерация двумерного массива
int[,] matix = FillTwoDimArray(n,m);

//3) Печатаем двумерный массив
PrintTwoDimArray(matix);


int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 6);
            j++;
        }
        i++;
    }
    return outArray;
}


//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            
            
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor(); 
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

void findElement(int[,] arr, int element) // поиск элемента
        {
            bool elemFind = false;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(element==arr[i, j])
                    {
                        
                        Console.WriteLine("Элемент {0} есть матрице. Индекс найденного элемента a[{1},{2}]", element, i, j);
                        elemFind=true;
                    }
                }
                    
            }
            if (elemFind==false)
            {
                Console.WriteLine("Такого элемента нет");
            }

        }

findElement(matix,num);