using System.Security.Cryptography.X509Certificates;

Console.Write("Введите числитель: ");
int n = Convert.ToInt32(Console.ReadLine());

int d;
do
{
    Console.Write("Введите знаменатель: ");
    d = Convert.ToInt32(Console.ReadLine());
} while (d == 0);

// Проверка на знак:
if (d < 0)
{
    n *= -1;
    d *= -1;
}


// Найдем НОД
int NOD(int x, int y)
{
    int temp;
    while (y != 0)
    {
        temp = y;
        y = x % y;
        x = temp;
    }
    return x;
}
int nod = NOD(Math.Abs(n), Math.Abs(d));

n = n / nod;
d = d / nod;

Console.Write("Результат: ");
Console.Write(n);
Console.Write(" / ");
Console.Write(d);