// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int a = 78;
string aText = Convert.ToString(a);
if (aText.Length > 2)
{
    Console.WriteLine(aText[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}