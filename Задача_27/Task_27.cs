// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine()!);

int sum(int x)
{
    int result = 0;

    while (x > 0)
    {
        result = result + (x % 10);
        x /= 10;
    }
    return result;
}

Console.WriteLine($"Сумма цифр введенного числа {x} = {sum(x)}.");