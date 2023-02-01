list1=[float(i) for i in input().split()] #Создаем список вещественных чисел
print(list1)  #Выводим список
max = 0
min = 9
for i in range(len(list1)):  #создаем цикл во всю длину списка
    if float(list1[i])>max:  #  сравниваем 
        max = float(list1[i])  #присваиваем максимальное
    if float(list1[i])<min:  # сравниваем
        min = float(list1[i])  #присваиваем минимальное
print(max-min)  #выводим разность