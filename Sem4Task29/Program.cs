int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод генерирует массив в диапозоне
int[] GenArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rnd.Next(begin, end);
    }
    return mas;
}
//метод печатает массив
void PrintArr(int[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length - 1; i++)
    {
        Console.Write(mas[i] + ", ");
    }
    Console.Write(mas[mas.Length - 1] + "]");
}

int masLen = ReadData("Введите размер массива: ");
int begin = ReadData("Введите первую границу диапозона чисел: ");
int end = ReadData("Введите вторую границу диапозона чисел: ");
int[] arr = GenArr(masLen, begin, end);
PrintArr(arr);