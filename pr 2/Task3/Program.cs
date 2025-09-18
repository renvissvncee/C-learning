using System.Security.Cryptography.X509Certificates;

Console.Write("Введите числитель: ");
int n = Convert.ToInt32(Console.ReadLine());

int d;
do
{
    Console.Write("Введите знаменатель: ");
    d = Convert.ToInt32(Console.ReadLine());
} while (d == 0);

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

while (NOD(n, d) != 1)
{
    n = n / NOD(n, d);
    d = d / NOD(n, d);
}

Console.WriteLine(n);
Console.WriteLine(d);