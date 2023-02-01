int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int[] Gen1DArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int CountElem(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        res+=arr[i];
    }
    return res;
}


int arrLen = ReadData("Введите длину массива.");
int begin = ReadData("Введите первую границу диапозона чисел: ");
int end = ReadData("Введите вторую границу диапозона чисел: ");
int[] testArr = Gen1DArr(arrLen,begin,end);
Print1DArr(testArr);
int count = CountElem(testArr);
PrintData("Сумма числе в четных позициях массива :"+count);