// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

//d = √ (х А – х В) 2 + (у А – у В) 2 + (z А – z В) 2

double Pront(string message)
{
  System.Console.Write(message);
  double result = Convert.ToDouble(System.Console.ReadLine());
  return result;
}

double AX = Pront("Ведите координаты AX: ");
double AY = Pront("Ведите координаты AY: ");
double AZ = Pront("Ведите координаты AZ: ");
double BX = Pront("Ведите координаты BX: ");
double BY = Pront("Ведите координаты BY: ");
double BZ = Pront("Ведите координаты BZ: ");

double d = Math.Round(Math.Sqrt((Math.Pow(AX - BX, 2)) + (Math.Pow(AY - BY, 2)) + (Math.Pow(AZ - BZ, 2))), 2); //2); (х А – х В) 2 + (у А – у В) 2+(z А – z В) 2
System.Console.WriteLine(d);

// double number = 5.321321321321;
// double result1 = Math.Round(number,2);// Округление
// double master = Math.Pow(number,2); // Возведение в квадрат
// double number1 = Math.Sqrt(25); // квадратный корень
// double result = Math.Round(Math.Sqrt(Math.Pow(number, 2)), 2);

