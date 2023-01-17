string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
if ((inputNum1 != null) && (inputNum2 != null))
{
    int number = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    if (number>number2)
    {
        Console.Write(number);
    }
    else
    {
        Console.Write(number2);
    }

}