// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int N = (int)Math.Abs(int.Parse(Console.ReadLine()!));
string numberstr = Convert.ToString(N);
if (N < 10000)
      {
        Console.WriteLine("Число должно быть пятизначное");
      }
else
    if (N > 99999)
      {
        Console.WriteLine("Число должно быть пятизначное");
      }

else
{
    Console.WriteLine (numberstr.Reverse( ).ToArray());
    if (numberstr[4] == numberstr[0] & numberstr[3] == numberstr[1])
    {
      Console.WriteLine("Число является палиндромом");
    }
    else
    {
      Console.WriteLine("Число не является палиндромом");
    }
}

    


  
  
