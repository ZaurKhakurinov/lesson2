// написать программу, которая на вход число и проверяет]]]6 кратно ли оно одновременно и 7 и 23. (14, 46, 161)

// Console.Clear();
// int num = int.Parse(Console. ReadLine());
// if (num % 7 == 0 & num % 23 == 0);
// {
//     Console.WriteLine($"{num} -> да");
// }
// else
// {
//     Console.WriteLine($"{num} -> нет");
// }

Console.Clear();
int num = int.Parse(Console.ReadLine());
if ((num%7==0) && (num%23==0))
{
    Console.WriteLine($"{num}-> да");
}else
{
    Console.WriteLine($"{num}-> нет");
}