import random
list = []  #Создаем пустой список
count = 0
num = int(input())   #вводим размер массива
for i in range(num):
    rnd_list = random.randrange(100, 999)   #создаем числа 
    list.append(rnd_list)  #вставляем их в список 
for i in range(1,len(list),2):  #проходимся по каждому четному индексу
    count+=list[i]    #складываем
print(list,count)




#36*
#Возможно я не так понял задачу, тут я нахожу колличество одинаковых пар
num= input().split()  #вводим список
counter=0
for i in range(len(num)):  #первый цикл на длину списка
    for j in range(i+1, len(num)):  #второй цикл на длину списка '''прибавил i+1, чтобы не сравнивать с самим собой'''
        if num[i]==num[j]:  #сравниваем 
            counter+=1  #добавлем в счетсчик
print(counter)   #выводим