string? inputNum1 = Console.ReadLine();
if(inputNum1!=null)
{
     int number = int.Parse(inputNum1);
     if (number%2==0)
     {
        Console.Write("Да");
     }
     else
     {
        Console.Write("Нет");
     }
}