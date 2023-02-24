// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
string? number=Console.ReadLine();

void Palindrome(string number)
{
     if (number[0]==number[4] && number[1]==number[3])
 {
    Console.WriteLine($"{number} - палиндром.");
 }
  else 
  {
    Console.WriteLine($"{number} - НЕ палиндром.");
  }
}
  if (number!.Length == 5)
  {
    Palindrome(number);
  }