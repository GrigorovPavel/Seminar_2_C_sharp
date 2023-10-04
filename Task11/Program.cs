// Напишите программу, которая 
// 1. выводит случайное 3х значное число и 
// 2. удаляет вторую цифру этого числа
// 456->46
// 782->72
// 918->98

int num = new Random().Next(100,1000);
Console.WriteLine(num);


int num1 = (num /100) * 10; // отавляем двухзначное число - первые две цифры
int num2 = num %10;  // получаем последнюю цифру

Console.WriteLine(num1+num2); // вывод 2х чисел - прибавляем к num1 + num2 
Console.WriteLine($"Вверху автоматически сгенерированное число {num}, а ниже вручную");

Console.WriteLine("Введите трёхзначное число :");
int userNum = Convert.ToInt32(Console.ReadLine());

if(userNum > 99 && userNum < 1000)
{
    int userNum1 = (userNum /100) * 10;
    int userNum2 = userNum %10;
    Console.WriteLine(userNum1+userNum2);
}
else
{
    Console.WriteLine($"{userNum} - не трёхзначное число!");
}

// Вариант с помощю МЕТОДА

int DelSecondDigit(int userNum)
{
    int userNum1 = (userNum /100) * 10;
    int userNum2 = userNum %10;
    return (userNum1+userNum2);
}

int result = DelSecondDigit(num);
Console.WriteLine($"Вариант с помощью МЕТОДА {result}");

