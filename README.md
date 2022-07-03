# ИТОГОВАЯ ПРОВЕРОЧНАЯ РАБОТА:
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.

Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

## Общие положения:

Решение тестового задания выполнено по средствам языка программирования **`C# в виде консольного приложения`**.

Программа позволяет пользователю определить размер массива, ввести любые текстовые данные в консоль. 
После чего, алгоритм находит текстовые данные, длина которых меньше, либо равна трем, формирует новые массив,
и выводит в консоль ответ.

Программа состоит из ***3 функций:***
- `FillArray` - функция заполнения массива данными;
- `FindSymbol` - функия поиска в массиве текстовой информации, длина которой меньше, либа равна трем.
- `Print` - функция вывода массива на экран.




## Функция `FillArray`.
Данная функция предназначена для ручного ввода с консоли 
текстовых данных.
В качестве удобства заполнения массива с консоли, при вводе данных отображается индекс массива.

В результате ввода такого формата данных ответ буде выглядеть следующим образом:
```
[массив с введенными данными] -> [,  ]
```

## Функция `FindSymbol`
 Функция предназначения для поиска текстовых данных, имеющих длину от 1 до 3 символов, и внесение найденных значений в новый массив.
Данная функиця принимает массив, который был заполнен пользователем.
Далее определяется длина нового массива:
```
int count = 0;
    string Symbol = String.Empty;
    for (int i = 0; i < ThreeSymbol.Length; i++)
    {
        Symbol = ThreeSymbol[i];
        if (Symbol.Length <= 3)
        {
            count++;
        }
    }
```
Таким образом, мы определили длину результирующего массива:

## Функция `Print`.
Данная функция предназначена для вывода данных, хранящихся в массиве.

## Вывод конечного результата
Результатом выполнения программы является вывод исходного и результирующего массива.