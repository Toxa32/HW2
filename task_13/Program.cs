//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(num);

if (num > 3)
{
    Console.WriteLine(str[2]);
}

else
{
    Console.WriteLine("Третьей цифры нет");
}
