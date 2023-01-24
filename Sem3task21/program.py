from math import sqrt, pow          #Импортировал модуль 
x1,x2,y1,y2,z1,z2 = int(input()),int(input()),int(input()),int(input()),int(input()),int(input())    #Ввел переменные
def d3(x1,x2,y1,y2,z1,z2):          #Создал функцию
    res = sqrt(pow(x1-x2,2)+pow(y1-y2,2)+pow(z1-z2,2))      #создал нашу формулу
    return res      #вывел ее
print(d3(x1,x2,y1,y2,z1,z2))    #Напечатал