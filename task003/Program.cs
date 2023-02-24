// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int index = 1;
  int length = cube.Length;
  while (index < length)
  {
    cube[index] = Convert.ToInt32(Math.Pow(index, 3));
    index++;
  }
}

void Print(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[]number = new int[cube + 1];
Cube(number);
Print(number); 