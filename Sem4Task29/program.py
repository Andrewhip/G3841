#29*
'''import random       #Вводим модуль
names = input('Введите имена друзей:').split(',')   #создаем список, где каждый его элемент будет отделяться запятой
print("За пивом идет:", random.choice(names))   #выводим рандомное значение из списка'''

#без сплита можно так сделать


import random   #Вводим модуль
num_friends=int(input('Введите количество друзей '))    #вводим количество ченловек
def name_friends(num_friends):      #создаем фунцию
    list=[]     #создаем пустой список
    for i in range(num_friends):        #создаем цикл
        friends = input('Введите имя друга ')       #вводим имена всех друзей по очереди
        list.append(friends)        #добавляем их все в наш список
    return list         #выводим список
print('За пивом идет',random.choice(name_friends(num_friends)))     