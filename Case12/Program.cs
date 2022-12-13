//Написать программу, которая на вход принимает 2 числа и будет выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1 то программа выводит остаток деления.
Console.Clear();
int num1 = int. Parse(Console. ReadLine());
int num2 = int.Parse(Console. ReadLine ());
if (num1 % num2 == 0)
{
    Console.WriteLine($"{num1}, {num2} -> кратно");
}
else
{
    Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1%num2}");
}
