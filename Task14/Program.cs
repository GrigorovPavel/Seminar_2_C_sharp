// Напишите программу, которая
// принимает на вход число и проверяет кратно ли оно оновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число :" );
int userNum = Convert.ToInt32(Console.ReadLine());

// Решение через int
int Multipule (int num)  
{
    int num1 = num % 7;
    int num2 = num % 23;
    return (num1+num2);
}

int result = Multipule(userNum);
if(result == 0)
{
    Console.WriteLine ("Кратно");
}
else
{
    Console.WriteLine("Не кратно!");    
}
// Решение через int

// // Решение через bool.
// bool MultipleTwoNumber (int num, int num1, int num2)  
// {
//     return num % num1 == 0 && num % num2 == 0;
// }

// int firstNum = 7;
// int secomdNum = 23;

// bool result = MultipleTwoNumber(userNum, firstNum,secomdNum);
// Console.WriteLine(result ? $"{userNum} -> да " : $"{userNum} -> нет ");
// // Решение через bool.

