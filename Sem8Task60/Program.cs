// Создаем трехмерный массив
void Gen3DArray(int[,,] arr, int min, int max)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(min, max + 1); 
            }
        }
    }
}
//Печатаем его
void Print3DArray(int[,,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



int[,,] array3D = new int[2, 2, 2];

Gen3DArray(array3D,10,100);
Print3DArray(array3D);