// Напишите программу, которая 
// 1. принимает на вход два числа и
// 2. выводит является ли первое число крато второму.
// 3. Если первое число не кратно второму, то программа выводит остаток от деления.
// 34,5 -> не кратно, остаток 4.
// 16,4 -> кратно.

Console.WriteLine("Введите первое число : ");
int firstNum = Convert.ToInt32(Console.ReadLine());  // просим ввести 1е число

Console.WriteLine("Введите второе число : ");
int secondtNum = Convert.ToInt32(Console.ReadLine());  // просим ввести 2е число

int RemainderNum (int num1, int num2)  // создаем МЕТОД , который будет использовать два числа
{
    return num1 % num2;   // ДЕЙСТВИЕ МЕТОДА (возвращает остаток от деления первого числа на второе)
}

int remainderNum = RemainderNum(firstNum, secondtNum);  // создаём переменную, в которую положим результат МЕТОДА
if(remainderNum == 0)                              //  условие: если результат МЕТОДА ==0 (нет остатка от деления), то
{
    Console.WriteLine($"{firstNum} , {secondtNum} -> кратно.");        // кратно, 
}
else
{
    Console.WriteLine($"{firstNum} , {secondtNum} -> не кратно,  остаток {remainderNum}");// если !==0 (есть остаток) то выполняется else
}
