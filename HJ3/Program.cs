// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Pront(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(System.Console.ReadLine());
  return result;
}

void Cub(int x)
{
for (int i = 1; i <= x; i++)
 {
  System.Console.Write($"{Math.Pow(i,3)} ");
 }
}



int number = Pront("Введите число: ");
Cub(number);