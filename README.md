### *Русский*

# Фильтрация массива строк

Этот проект является итоговой контрольной работой по основному блоку обучения "Разработчик. Основной блок" в GeekBrains. Работа направлена на проверку знаний и навыков, полученных в ходе обучения, и представляет собой программу на языке C#, которая принимает массив строк и возвращает новый массив, содержащий только те строки, длина которых не превышает 3 символа. Массив строк может быть введен пользователем или задан заранее в коде.

## Рабочий процесс

Программа начинается с интерактивного пользовательского интерфейса, представленного в виде меню. Пользователь выбирает массив для обработки, после чего программа приступает к фильтрации. Результаты затем отображаются на экране.

![Workflow](Workflow.png)

## Описание алгоритма

### Алгоритм

1. **Отображение меню**: Пользователю предлагается выбор из нескольких предопределенных массивов или возможность ввести собственный массив.

2. **Чтение выбора пользователя**: Программа регистрирует выбор пользователя и устанавливает соответствующий массив для дальнейшей обработки или ожидает ввод элементов массива пользователя через пробел.

3. **Фильтрация массива**: Программа вызывает функцию `FilterArray()`, которая проходит по всем элементам исходного массива и создает новый массив, содержащий только те строки, длина которых не превышает 3 символа.

4. **Вывод результата**: Программа выводит элементы полученного массива. Если полученный массив пуст, программа выводит сообщение о том, что ни один из элементов исходного массива не подходит под условие.

![Algorithm](Algorithm.png)

## Установка и запуск

Чтобы запустить программу, выполните следующие шаги:

1. Клонируйте репозиторий на свой компьютер.
2. Откройте проект в среде разработки, поддерживающей C# (например, в Visual Studio Code).
3. Запустите программу.

## Лицензия

Этот проект лицензирован под условиями лицензии MIT.

---
---
---

### *English*

# Filtering an array of strings

This project is the final test paper for the main unit of study "Developer. Basic block" in GeekBrains. The work is aimed at testing the knowledge and skills acquired during the training, and represents a C# program that takes an array of strings and returns a new array containing only those strings whose length does not exceed 3 characters. The array of strings can be entered by the user or specified in advance in the code.

## Workflow

The program starts with an interactive user interface presented as a menu. The user selects the array to be processed and the program proceeds with filtering. The results are then displayed on the screen.

![Workflow](Workflow.png)

## Algorithm description

### Algorithm

1. **Menu Display**: The user is offered a choice of several predefined arrays or the option to enter their own array.

2. **Reading User Selection**: The program registers the user's selection and sets the appropriate array for further processing or waits for the user to enter array elements via space.

3. **Filtering the array**: The program calls the `FilterArray()` function, which goes through all elements of the original array and creates a new array containing only those strings that are less than 3 characters long.


4. **Result output**: The program outputs the elements of the resulting array. If the resulting array is empty, the program outputs a message that none of the elements of the original array matches the condition.

![Algorithm](Algorithm.png)

## Install and Run

To run the program, follow the steps below:

1. Clone the repository to your computer.
2. Open the project in a development environment that supports C# (for example, Visual Studio Code).
3. Run the program.

## License

This project is licensed under the terms of the MIT license.

---