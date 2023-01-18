/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt16(numberStr);

int i = 1;
int remainderNumber = number % 2;
if (number <= i) {
    Console.Write("ОШИБКА! Введите число > 1");
}
while (i <= number) {
    int remainder = i % 2;
    if (remainder==0) {
        Console.Write($"{i}");
        //определяем, что нужно ставить после числа: запятую или точку
        if (   ((remainderNumber == 0) && (i == number   ))    //Number четный
            || ((remainderNumber != 0) && (i == number -1))) { //number нечет
                Console.Write(". ");
        }
        else {
            Console.Write(",  ");
        }
    }
    i++;
}