// Напишите программу которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

Console.Clear ();
int num = new Random(). Next(100,1000);
Console.WriteLine($"число {num}");
int num1 = num/100;
int num2 = num%10;
Console.WriteLine($"Цифра {num1}{num2}");