//Задача 18: Напишите программу, которая по 
//заданному номеру четверти, показывает диапазон 
//возможных координат точек в этой четверти (x и y).

int qarter = Convert.ToInt32(Console.ReadLine());
if (qarter == 1) Console.WriteLine("x > 0 и y > 0");
if (qarter == 2) Console.WriteLine("x < 0 и y > 0");
if (qarter == 3) Console.WriteLine("x < 0 и y < 0");
if (qarter == 4) Console.WriteLine("x > 0 и y < 0");
