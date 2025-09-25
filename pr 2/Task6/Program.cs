int N = 0;
int X = 0;

Console.Write("Введите количество бактерий: ");
N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество антибиотика: ");
X = Convert.ToInt32(Console.ReadLine());

for (int i = 10; i > 0; i--)
{
    if (N <= 0)
    { 
        break;
    }
    N *= 2;
    N = (N - X * i) < 0 ? 0 : (N - X * i);
    Console.WriteLine($"После {11 - i} часа бактерий осталось {N}");
}