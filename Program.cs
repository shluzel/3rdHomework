// See https://aka.ms/new-console-template for more information
Console.Clear();

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write ("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int firsthalf = a/10000 *10 + a/1000 %10;
int secondhalf = a%10*10 +a%100/10;
if (firsthalf == secondhalf) {
    Console.Write($"Число {a} является палиндромом." );
}
else {
    Console.Write($"Число {a} не является палиндромом." );
}
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.Write ("Введите последовательно (x,y,z) координаты первой точки в 3D пространстве, нажимая Enter после каждого значения: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите последовательно (x,y,z) координаты второй точки в 3D пространстве, нажимая Enter после каждого значения: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double l = Math.Sqrt (Math.Pow((x2-x1),2)+ Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));

Console.Write($"Расстояние между двумя точками ({x1},{y1},{z1}) и ({x2},{y2},{z2}) получилось равным {l:f5}." );
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write ("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Кубы чисел от 1 до введенного числа: ");
for (int i = 1; i<=a; i++) {
    Console.Write ($"{Math.Pow(i,3)} ");
}