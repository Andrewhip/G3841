'''def exponentiation(numA, numB):
    res = 1
    while numB!=0:
       res*=numA
       numB-=1
    return res

number1, number2 = int(input('Введите число ')),int(input('Введите степень '))

print(exponentiation(number1,number2))'''

#25*

operation = input('Введите операцию ')

def operations(op):
    if operation == '+':
        return 'Вы выбрали сложение'
    elif operation == '-':
        return 'Вы выбрали вычитание'
    elif operation == '/':
        return 'Вы выбрали деление'
    elif operation == '*':
        return 'Вы выбрали умножение'
    elif operation == '**':
        return 'Вы выбрали возведение в степень'
    else:
        return 'Неизвестная операция'
print(operations(operation))


a = int(input('Введите первое число '))
b = int(input('Введение второе число '))
def Culc(a,b,operation):
    if operation == '+':
        return  a + b
    elif operation == '-':
        return  a - b
    elif operation == '/':
        return a / b
    elif operation == '*':
        return a * b
    elif operation == '**':
        return a**b
    else:
        return 'Неизвестная операция'

print('Результат будет' ,Culc(a,b,operation))