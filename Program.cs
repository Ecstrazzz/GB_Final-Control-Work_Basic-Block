﻿// # Итоговая контрольная работа по основному блоку

// ## Урок 1. Контрольная работа

// Данная работа необходима для проверки ваших знаний и навыков
// по итогу прохождения первого блока обучения на программе
// Разработчик. Мы должны убедится, что базовое знакомство с IT
// прошло успешно.

// Задача алгоритмически не самая сложная, однако для полноценного
// выполнения проверочной работы необходимо:

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой
// основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим
// проектом (не должно быть так, что всё залито одним коммитом,
// как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо
// равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не
// рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Решение:

Console.Clear();
Console.WriteLine("Выберите вариант массива:");
Console.WriteLine("1. [“Hello”, “2”, “world”, “:-)”]");
Console.WriteLine("2. [“1234”, “1567”, “-2”, “computer science”]");
Console.WriteLine("3. [“Russia”, “Denmark”, “Kazan”]");
Console.WriteLine("4. Ввести массив самостоятельно");

string[] array;

switch (Console.ReadLine())
{
    case "1":
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2":
        array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    case "4":
        Console.WriteLine("Введите элементы массива, разделяя их пробелом:");
        array = Console.ReadLine()!.Split(' ');
        break;
    default:
        Console.WriteLine("Неизвестный выбор. Используем первый массив по умолчанию.");
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
}

string[] resultArray = FilterArray(array);

Console.WriteLine("Результат:");
Console.Write("[");
foreach (string s in resultArray)
{
    Console.Write(" "+s+" ");
}
Console.Write("]");

static string[] FilterArray(string[] array)
{
    int count = 0;

    // Подсчитываем количество элементов, которые удовлетворяют условию
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;

    // Заполняем результирующий массив
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[index] = array[i];
            index++;
        }
    }

    return result;
}
