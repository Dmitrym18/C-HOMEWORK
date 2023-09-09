// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число: ");
// int number = int.Parse(Console.ReadLine());
// int secondDigit = (number%100-number%10)/10;
// Console.WriteLine(secondDigit);
 

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 99 && number < 1000)
// {
//     int secondDigit = (number%100-number%10)/10;
//     Console.WriteLine(secondDigit);
// }
// else
// System.Console.WriteLine("Не 3х значное число!");

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите трехназночное число");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;
}
Console.WriteLine($"Введенное число `{number}`");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра `{secondRank}`");
