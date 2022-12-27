// See https://aka.ms/new-console-template for more information
Console.Clear();

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
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
