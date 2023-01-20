
int day = int.Parse(Console.ReadLine()??"0");
if (day>7)
{
    Console.WriteLine("Не день недели");
}
else
{
    if (day>5)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
    
}