def sum_numbers(num):       #Создаю функцию на подсчет суммы символов
    res = 0
    while num != 0:
        res += num % 10
        num = num // 10
    return res
num = int(input())      #ввод пользователя
print(sum_numbers(num))     #вывод нашей функции


