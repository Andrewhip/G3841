string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
string? inputNum3 = Console.ReadLine();
if ((inputNum1 != null) && (inputNum2 != null) && (inputNum3 != null)) 
{
    int number = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    int number3 = int.Parse(inputNum3);
    if ((number>number2) && (number>number3))
    {
        Console.Write (number);
    }
    if ((number2>number) && (number2>number3))
    {
        Console.Write(number2);
    }
    else
    {
        Console.Write(number3);
    }
}