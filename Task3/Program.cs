// Напишите программу, которая принимает на вход число(N) и выдает таблицу кубов чисел от 1 до N

Console.Write("Введите число: ");
int N = (int)Math.Abs(int.Parse(Console.ReadLine()!));
for (int i = 1; i <= N; i++)

{
    double cube = Math.Pow(i, 3);
    if (i == N)
    Console.Write(cube);
    else
    {
        Console.Write(cube + ",");
    }
}
