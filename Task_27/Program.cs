Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a > 0)
{
  int count = a % 10;
  a = a / 10;
  sum = sum + count;
}
Console.WriteLine("Ответ: " + sum);