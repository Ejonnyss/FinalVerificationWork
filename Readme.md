# Итоговая проверочная работа

## **Задание:**
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

**Примеры:**


```
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
['1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [
```
____
## **Решение:** 

*При выполнения задания будет использовано два массива, первый массив будет задан пользователем через клавиатуру, второй будет заполнен элементами первого массива, которые удовлетворяют условию отбора*

### 1. Создание массива
* Запросим у пользователя количество элементов массива (size). 
* Создадим массив строк (array) и запросим у пользователя ввод каждого i-го элемента.
Используем цикл for с 0-го элемента до элемента, равного заданному size.
### 2. Нахождение размера второго массива
* Вводим счетчик (count) и количество символов для отбора (limit), равную по условию задачи 3.
* Проходим по всем элементам введенного массива и записываем в счетчик кол-во элементов, удовлетворяющих по условию (количества символов).
* Полученное значение счетчика используем для определения размера второго массива. 
### 3. Заполнение второго массива
* Создаем второй массив строк (editedArray) с размером count.
* Повторно проходим по всем элементам массива и присваиваем элементы массива array элементам массива editedArray при удовлетворении условия (количества символов).
### 4. Выводим на печать исходный и отредактированные массивы. 

____

## **Проверка:**


```
Введите число элементов массива: 
4
Введите 1 элемент: 
hello
Введите 2 элемент: 
2
Введите 3 элемент: 
world
Введите 4 элемент: 
:-)

Исходный массив:
hello 2 world :-) 

Отредактированный массив:
2 :-) 
```
____