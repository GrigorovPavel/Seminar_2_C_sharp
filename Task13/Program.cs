// 13: Напишите программу, которая 
// 1. принимает на вход любое число и 
// 1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ThirdNumber (int number)
{
    while (number > 999)
    {
        number = number / 10; 
    }
    return number % 10;
}

bool VerificationThirdNumber(int number)
{
    if(number<100)
    {
        Console.WriteLine($"{number} -> третьей цифры нет.");
        return false;
    }
    else
    {
        return true;
    }
}

Console.WriteLine("Please enter number:");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (VerificationThirdNumber(userNumber))
{
    Console.Write($"{userNumber} -> " );
    Console.WriteLine (ThirdNumber(userNumber));
}




