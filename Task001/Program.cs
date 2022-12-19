/*
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
string  numberFirstStr = Console.ReadLine() ??""; 
int numberFirst = Convert.ToInt32(numberFirstStr);

Console.WriteLine("Введите второе число: ");
string  numberSecondStr = Console.ReadLine() ??""; 
int numberSecond = Convert.ToInt32(numberSecondStr);

if (numberFirst != numberSecond)
{
    if (numberFirst < numberSecond)
    {
        Console.WriteLine($"Минимальное число {numberFirst} Максимальное число {numberSecond}");
    
    }
    else
    {
        Console.WriteLine($"Минимальное число {numberSecond} Максимальное число {numberFirst}");
    
    }
}
else
Console.WriteLine("Введенные числа равны между собой");