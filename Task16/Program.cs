// Напишите программу, которая
// 1. принимает на входе два числа и
// 2. проверяет является ли одно число квадратом другого.
// 5,25 - да
// -4,16 - да
// 25,5 - да
// 8,9 - нет

// Решение через bool

bool IsSquareTwoNumbers(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}

Console.WriteLine("Введите первое число:");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondtNum = Convert.ToInt32(Console.ReadLine());

bool result = IsSquareTwoNumbers(firstNum, secondtNum);
Console.WriteLine(result ? $"{firstNum}, {secondtNum}-> да " : $"{firstNum}, {secondtNum} -> нет ");

// Решение через int

