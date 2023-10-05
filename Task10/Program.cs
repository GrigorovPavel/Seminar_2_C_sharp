// 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int SecondNumber (int num)
{
    if(userNumber > 99 && userNumber < 1000)
    {
        return userNumber;
    }
    else
    {
        Console.WriteLine($"{userNumber} -> не трехзначное число.");
        return userNumber * 0;
        
    }

}

int result = SecondNumber(userNumber);
if ( result > 1)
{
    int secondNumber = (result / 10) %10;
Console.WriteLine($"Второе число в {result} -> {secondNumber}");
}
