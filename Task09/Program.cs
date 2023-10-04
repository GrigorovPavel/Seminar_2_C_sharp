// Напише программу, которая 
// 1. выводит случайное число из отрезка [10,99] и
// 2. показывает наибольшую цифру числа.
// 78->8
// 12->2
// 85->8

using System.Threading.Tasks.Dataflow;

int MaxDigit(int num)  // Создали Метод MaxDigit. Методы лучше указывать перед КОДОМ.
{
    int firstDigit = num /10; 
    int secondDigit = num %10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int number = new Random().Next(10, 99 + 1);
Console.WriteLine($"случайное число из отрезка [10, 99] -> {number}");

// int numA = number /10; // находим первую цифру
// int numB = number %10; // находим вторую цифру

// if(numA > numB)
// {
//     Console.WriteLine($"наибольшая цифра числа -> {numA}");
// }
// else
// {
//     Console.WriteLine($"наибольшая цифра числа -> {numB}");
// }

// int maxNum = numA > numB ? numA : numB;
// Console.WriteLine($"Наибольшая цифра числа -> {maxNum}");

int maxNum = MaxDigit (number);
Console.WriteLine($"Наибольшая цифра числа -> {maxNum}");

