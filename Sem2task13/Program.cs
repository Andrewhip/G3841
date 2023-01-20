int num = int.Parse(Console.ReadLine()??"0");

if (num< 100)

{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    int n = 0;
    while (num>99)
    {
        n=num%10;
        num=num/10;
    }
    
    Console.WriteLine(n);
}
