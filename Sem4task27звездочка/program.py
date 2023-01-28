num=input()         #Вводим строку
def sum_numbers_str(num):      #Создаю функцию на подсчет суммы символов
    total = 0       #создал переменную в которую буду вставлять сумму
    for i in range(len(num)): #создал цикл на длину строки
        total+=int(num[i])  #преобразовываю строку в число и суммирую все цифры
    return str(total)

print(sum_numbers_str(num))     #вывод нашей функции