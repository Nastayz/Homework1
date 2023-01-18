/*Задача 6: Напишите программу, которая на вход принимает число 
и выдаёт, является ли число чётным (делится ли оно на два 
без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt16(numberStr);
int remainder = number % 2;
if (remainder == 0) {
    Console.WriteLine("да");
}
else {
    Console.WriteLine("нет");
}