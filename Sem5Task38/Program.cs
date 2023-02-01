double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

double[] Gen1DArr(int num, int begin, int end)
{
    Random rnd = new Random();
    double[] arr = new double[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end) + rnd.NextDouble();
    }
    return arr;
}

void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


double MinMax(double[] arr)
{
    double max = double.MinValue;
    double min = double.MaxValue;
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i]>max)
        {
            max=arr[i];
        }
        if(arr[i]<min) 
        {
            min=arr[i];
        }
    }
    return(max-min);
}


double arrLen = ReadData("Введите длину массива.");
double begin = ReadData("Введите первую границу диапозона чисел: ");
double end = ReadData("Введите вторую границу диапозона чисел: ");
double[] testArr = Gen1DArr((int)arrLen,(int)begin,(int)end);
Print1DArr(testArr);
double count = MinMax(testArr);
PrintData("разница максимального и минимального числа равна :"+count);