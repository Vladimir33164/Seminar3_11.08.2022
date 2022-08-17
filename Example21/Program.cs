//Задача 21: Напишите программу, которая 
//принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D 
//пространстве.

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

//result = sqrt ((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))

Console.Write("Введите координату Х точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату Y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите координату Х точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите координату Y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine()); 

double result = Math.Sqrt((Math.Pow(x1-x2,2) + (Math.Pow(y1-y2,2))));
//Pow - число, степень.
//Sqrt - число от которого берём корень.
Console.WriteLine($"Расстояние {Math.Round(result,3)}");

//Math.Pow(x1-x2,2) -> выражение x1-x2, возводится в степень 2 => (x1-x2) * (x1-x2)
//Math.Round - число, до скольки заков округлять остаток. Например:Math.Round(1.7215, 2) = 1.72
//Math.Sqrt(25) -> 5. Корень из 25 = 5.