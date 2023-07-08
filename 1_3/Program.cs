// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine(" Введите номер дня недели: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// if (number1 == 1)
// {
//   Console.WriteLine("Нет");
// }
// else if (number1 == 2)
// {
//   Console.WriteLine("Нет");
// }
// else if (number1 == 3)
// {
//   Console.WriteLine("Нет");
// }
// else if (number1 == 4)
// {
//   Console.WriteLine("Нет");
// }
// else if (number1 == 5)
// {
//   Console.WriteLine("Нет");
// }
// else if (number1 == 6)
// {
//   Console.WriteLine("Да");
// }
// else if (number1 == 7)
// {
//   Console.WriteLine("Да");
// }
// else
// {
//   Console.WriteLine("Такого дня нет");
// }

Console.WriteLine(" Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day <= 5)
{
  Console.WriteLine("Нет, будний день");
}
else if (day > 5 && day <= 7)
{
  Console.WriteLine("Да, выходной день");
}
else
{
  Console.WriteLine("Такого дня нет");
}
