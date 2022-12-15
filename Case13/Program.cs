// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
string str = Console. ReadLine().ToString();
int[] b = new int[str.Length];
for(int i=0;i<b.Length;i++)

if( b.Length > 2)
    {
    Console.WriteLine($"{Console. ReadLine()} -> {str[2]}");
    }
else
{
    Console.WriteLine($"{Console. ReadLine()} -> третьей цифры нет");
}
    
// Знаю что криво работает. Идея была такая, чтобы из заданного числа сделать массив и по индексу найти нужную цифру. 
// Но как правильно это реализовать не понимаю