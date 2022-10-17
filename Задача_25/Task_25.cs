// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число А: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В: ");
int y = int.Parse(Console.ReadLine()!);

int Step(int X, int Y)
{
    int Step = 1;
    int i = 0;

    while (i < Y)
    {
        Step *= X;
        i++;
    }
    return Step;
}

Console.WriteLine($"Результат: {Step(x, y)}");