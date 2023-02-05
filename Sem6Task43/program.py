k1 = float(input())
b1 = float(input())
k2 = float(input())
b2 = float(input())


def points_of_intersection(k1, b1, k2, b2):
    x = (-b2 + b1)/(-k1 + k2)
    y = k2 * x + b2
    return x, y

print('Точки пересечения 2 прямых', points_of_intersection(b1, k1, b2, k2))