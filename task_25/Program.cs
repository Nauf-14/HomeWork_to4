Console.Clear();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int count = 1;
for (int i = 1; i <= B; i++)
  count = count * A;
Console.WriteLine(count);