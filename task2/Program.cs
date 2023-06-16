// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(100000);
if (number < 100)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    int number1 = number % 1000;
    int number2 = number1 / 100;
    Console.WriteLine($"{number} -> {number2}");
}
