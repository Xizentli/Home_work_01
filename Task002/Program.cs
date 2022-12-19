/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
string  numberFirstStr = Console.ReadLine(); 
int numberFirst = Convert.ToInt32(numberFirstStr);

Console.WriteLine("Введите второе число: ");
string  numberSecondStr = Console.ReadLine(); 
int numberSecond = Convert.ToInt32(numberSecondStr);

Console.WriteLine("Введите третье число: ");
string  numberThirStr = Console.ReadLine(); 
int numberThir = Convert.ToInt32(numberThirStr);

int max = numberFirst;

if (numberFirst > max) max = numberFirst;
if (numberSecond > max) max = numberSecond;
if (numberThir > max) max = numberThir;

Console.WriteLine($"Максимальное число {max}");