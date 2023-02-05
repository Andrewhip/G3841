//Через методы вообще ни в какую не получается, сидел часа 3-4 просто так, психанул и сделал без них

Console.Write("Введите числа через запятую: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse); //читаем массив отвеляя каждый элемент запятой
int count = 0; //создаем счетчик
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)  //проверям элементы
    {
        count++; //добавляем в счетчик
    }
}
 
Console.WriteLine($"Кол-во чисел больше 0: {count}");




//41*



// Console.Write("Введите колличество чисел: ");
// int num = int.Parse(Console.ReadLine()); //Пользовател воодит число
// int count = 0;
// for (int i = 0; i < num; i++) //создаем цикл
// {
//     Console.Write($"Введите число {i + 1}: ");
//     int x = int.Parse(Console.ReadLine()); //считываем каждое число
//     if (x > 0) //ставим условие что x больше 0
//         count++; //пибовляем 1
// }
// Console.WriteLine($"Положительных чисел: {count}");
