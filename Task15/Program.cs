// 15: Напишите программу, которая 
// 1. принимает на вход цифру, 
// 2. обозначающую день недели, и 
// 3. проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// ЭВРИКА!!!
// Console.WriteLine("Введите первое число:");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число:");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int Sum(int a, int b)
// {
//     int result = a + b;
//     return result;
// }

// int c = Sum(number1, number2);
// Console.WriteLine($"сумма {number1} и {number2} = {c}");
// ЭВРИКА!!!


Console.WriteLine("Введите номер дня недели:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int WeekEnd (int number)
{
    if(number > 5 && number <=7)
    {
        Console.WriteLine("Ура! Выходной!");
        return number;
    }
    else if(number > 0 && number <= 5)
    {
        Console.WriteLine("Придется поработать!");
        return number;
    }
    else 
    {
        Console.WriteLine($"{number} -> дня недели с таким номером нет!");
        return number;
    }
}

int weekEnd = WeekEnd(userNumber);



// Решение без МЕТОДОВ!

// Console.WriteLine("Введите номер дня недели : ");
// string dayNumber = Console.ReadLine();

// if (dayNumber == "1")
// {
//     Console.WriteLine($"{dayNumber} -> Нет.");
// }
// else if (dayNumber == "2")
// {
//     Console.WriteLine($"{dayNumber} -> Нет.");
// }
// else if (dayNumber == "3")
// {
//     Console.WriteLine($"{dayNumber} -> Нет.");
// }
// else if (dayNumber == "4")
// {
//     Console.WriteLine($"{dayNumber} -> Нет.");
// }
// else if (dayNumber == "5")
// {
//     Console.WriteLine($"{dayNumber} -> Нет.");
// }
// else if (dayNumber == "6")
// {
//     Console.WriteLine($"{dayNumber} -> Да.");
// }
// else if (dayNumber == "7")
// {
//     Console.WriteLine($"{dayNumber} -> Да.");
// }
// else 
// {
//     Console.WriteLine("Дня недели с таким номером нет");
// }

// Переделать с методом!

// int monday 
// int tuesday 
// int wednesday 
// int thursday 
// int friday 
// int saturday 
// int sunday



// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

// Console.Write("Can you enter number:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DecimalToBinary(number));

// int DecimalToBinary(int num)
// {
//     int result = 0;
//     int mult = 1;
//     while (num > 0)
//     {
//         result += num % 2 * mult;
//         num = num / 2;// num /= 2 //
//         mult *= 10;
//     }
//     return result;
// }
//  Рекурсия !!!
// int ConvertDecToBinRecursion(int dec)
// {
//     if(dec < 2) return dec;
//     else
//     {
//         return 10 * ConvertDecToBinRecursion(dec / 2) + (dec % 2);
//     }
// }

// 11:05
// рекурсией

// 11:05

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

// Console.Write("Can you enter number:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DecimalToBinary(number));
// Console.WriteLine(DecimalToBinaryStr(number));

// int DecimalToBinary(int num)
// {
//     int result = 0;
//     int mult = 1;
//     while (num > 0)
//     {
//         result += num % 2 * mult;
//         num = num / 2;// num /= 2 //
//         mult *= 10;
//     }
//     return result;
// }

// string DecimalToBinaryStr(int num)
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num % 2 + result;
//         num = num / 2;// num /= 2 //
//     }
//     return result;
// }



// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


//  Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

// int[] GenerateArray(int min, int max, int size)
// {
//     int[] arr = new int[size];
//     var rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }

//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }


// int[] CopyArray(int[] arr)
// {
//     int[] arrayA = new int[arr.Length];

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arrayA[i] = arr[i];
//     }
//     return arrayA;
// }

// int[] res = GenerateArray(1, 10, 5);

// PrintArray(res);

// int[] resA = CopyArray(res);
// resA[0] = 10000;

// int[] resB = res; // ссылка на исходный массив res
// res[3] = -100;

// // PrintArray(resA);

// PrintArray(resB);




//   https://learn.microsoft.com/ru-ru/dotnet/api/system.string.split?view=net-7.0