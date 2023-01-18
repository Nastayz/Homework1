/*Задача 4: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int GetNumber ()
{
    string numberStr = Console.ReadLine();
    int number = Convert.ToInt16(numberStr);
    return number;
}
Console.WriteLine("Введите число 1: ");
int number1=GetNumber();

Console.WriteLine("Введите число 2: ");
int number2=GetNumber();

Console.WriteLine("Введите число 3: ");
int number3=GetNumber();

int max=number1;

if (number2 > max) {
    max = number2;
}
if (number3 > max) {
    max = number3;
}
Console.WriteLine($"max = {max} ");