string? inputNum1 = Console.ReadLine();
string result = string.Empty;
if(inputNum1!=null)
{
    int number = int.Parse(inputNum1);
    for(int i = 2; i < number; i=i+2)
    result=result+i+",";
    if (number%2==0)
    {
        result=result+number;
    }
    result = result.TrimEnd(',');
    Console.WriteLine(result);
}