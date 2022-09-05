// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.WriteLine("Введите целое трехзначное число");
int numberA = int.Parse (Console.ReadLine()); // пользовательский ввод
int digit3 = (numberA % 10) ;

if(numberA > 99)
    Console.WriteLine($"Третья цифра числа {numberA} - {digit3}");
else
    Console.WriteLine($"Вы ввели некорректное число");
