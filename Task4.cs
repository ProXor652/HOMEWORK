/* //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Enter first number: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter two number: ");
double b = Convert.ToDouble(Console.ReadLine());

double stepen = Math.Pow(a, b);
  {
  Console.WriteLine("Stepen numbers A from B ravna: " + stepen);
  } */

/* //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.WriteLine("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());

  int Sum(int a)
  {
    int counter = Convert.ToString(a).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = a - a % 10;
      result = result + (a - advance);
      a = a / 10;
    }
   return result;
  }

int sum = Sum(a);
Console.WriteLine("Sum number: " + sum); */

/* //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(0,9);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + ",");
        position++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array); */