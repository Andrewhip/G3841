#34
import random
list = [] #создаем пустой список
count = 0  
num = int(input())  #вводим число
for i in range(num):  
    rnd_list = random.randrange(100, 999)  #создаем числа 
    list.append(rnd_list)  #и вставляем их в список
for i in range(len(list)):   #создаем новый цикл на длину массива 
    if list[i]%2==0:   #если число четное
        count+=1    #вставляем в переменную каунт
print('Массив:',list,'Колличество четных элементов', count)
#34*
def bubble(list):
    n = len(list)
    for i in range(n - 1):
        for j in range(n - i - 1):
            if list[j] > list[j + 1]:
                list[j], list[j + 1] = list[j + 1], list[j]
    return list
print(bubble(list))