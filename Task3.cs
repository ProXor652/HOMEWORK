/* //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine());

while(num >= 100000)
    {
    Console.WriteLine("Введите пятизначное число ");
    num = int.Parse(Console.ReadLine());
    }
while(num <= 9999)
    {
    Console.WriteLine("Введите пятизначное число ");
    num = int.Parse(Console.ReadLine());
    }

int a1 = num/10000;
int a2 = num%10;
int b1 = (num%10000)/1000;
int b2 = (num%100)/10;
if(a1 == a2 && a2 == b2)
     {
        Console.WriteLine(num + " -> является палиндромом");
     }
else
    {
        Console.WriteLine(num + " -> не является палиндромом");
    } */

/* //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координаты xa: ");
double xa = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты ya: ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты za: ");
double za = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты xb: ");
double xb = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты yb: ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты zb: ");
double zb = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
   {
   Console.WriteLine("Расстояние между точками X (" +xa+","+ya+","+za + ") и Y (" +xb+","+yb+","+zb+ ") равен " + distance);
   } */

/* //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Num(int[] num)
{
int counter = 0;
int length = num.Length;
while (counter <  length)
  {
    num[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}
void PrintArry(int[] coll)
{
int count = coll.Length;
int index = 0;
while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
}
int[] arry = new int[num+1];
Num(arry);
PrintArry(arry); */