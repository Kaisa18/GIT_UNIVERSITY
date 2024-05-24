def trapezoidal_rule(a, b, func, n = 12):
    h = (b - a) / n #Вычисляем шаг интегрирования
    integral = 0.5 * (func(a) + func(b)) #вычисления части формулы
    for i in range(1, n):
        integral += func(a + i * h)
    integral *= h # Умножаем значение функции на шаг
    return integral

def simpsons_rule(a, b, func, n = 12):
    # Проверяем, что количество разбиений четное
    if n % 2 != 0:
        print("Количество разбиений должно быть четным")
    else:
        h = (b - a) / n  # Вычисляем шаг интегрирования
        x = a
        integral = func(a) + func(b)  # функция в граничных точках

        # Суммируем значения функции для точек с четными и нечетными индексами
        for i in range(1, n):  
            # Определяем коэффициент для текущего значения функции
            if i % 2 == 0:
                coefficient = 2
            else:
                coefficient = 4
            x += h
            integral += coefficient * func(x)  # Добавляем значение функции, умноженное на соответствующий коэффициент

        integral *= h / 3  # Умножаем сумму значений функции на шаг и на 1/3

        return integral

def my_function(x):
    return (3 * x) / (x ** 2 + 1)

my_integral = trapezoidal_rule(0, 4, my_function)
simpson_integral = simpsons_rule(0, 4, my_function)
print("Приближенное значение интеграла(метод трапеции):", my_integral)
print("Приближенное значение интеграла(Метод Симпсона):", simpson_integral)
