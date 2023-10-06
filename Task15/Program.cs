// 15: Напишите программу, которая 
// 1. принимает на вход цифру, 
// 2. обозначающую день недели, и 
// 3. проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели : ");
string dayNumber = Console.ReadLine();

if (dayNumber == "1")
{
    Console.WriteLine($"{dayNumber} -> Нет.");
}
else if (dayNumber == "2")
{
    Console.WriteLine($"{dayNumber} -> Нет.");
}
else if (dayNumber == "3")
{
    Console.WriteLine($"{dayNumber} -> Нет.");
}
else if (dayNumber == "4")
{
    Console.WriteLine($"{dayNumber} -> Нет.");
}
else if (dayNumber == "5")
{
    Console.WriteLine($"{dayNumber} -> Нет.");
}
else if (dayNumber == "6")
{
    Console.WriteLine($"{dayNumber} -> Да.");
}
else if (dayNumber == "7")
{
    Console.WriteLine($"{dayNumber} -> Да.");
}
else 
{
    Console.WriteLine("Дня недели с таким номером нет");
}

// Переделать с методом!

// int monday 
// int tuesday 
// int wednesday 
// int thursday 
// int friday 
// int saturday 
// int sunday