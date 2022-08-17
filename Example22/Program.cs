//Задача 22: Напишите программу, которая 
//принимает на вход число (N) и выдаёт таблицу 
//квадратов чисел от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

int N = Convert.ToInt32(Console.ReadLine());
//int start = 1;
//while (start <= N)
//{
    //Console.WriteLine(Math.Pow(start,2));
    //start++;
//}
for (int start = 1; start <= N; start++)
{
    Console.WriteLine(Math.Pow(start,2));
}
