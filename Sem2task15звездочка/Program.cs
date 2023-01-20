var days = new Dictionary<int, string>()
{
    [1] = "Рабочий",
    [2] = "Рабочий",
    [3] = "Рабочий",
    [4] = "Рабочий",
    [5] = "Рабочий",
    [6] = "Выходной",
    [7] = "Выходной",
};
int day = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(days[day]);