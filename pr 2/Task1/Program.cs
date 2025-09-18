Console.Write("Введите 'x': ");
double x = Convert.ToDouble(Console.ReadLine());
bool xIsGood = false;
while (!xIsGood)
{
    if (x <= -1 || x >= 1)
    {
        Console.WriteLine("'x' должен быть в пределах (-1; 1)!");
        x = Convert.ToDouble(Console.ReadLine());
    }
    else
    {
        xIsGood = true;
    }
}

Console.Write("Введите 'n': ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите точность 'e': ");
double e = Convert.ToDouble(Console.ReadLine());

int double_fact(int x) {
    int res = 1;
    for (int i = (x % 2) + 2; i <= x; i+=2)
    {
        res *= i;
    }
    return res;
 }


double result = 0;
double term = 0;
Console.Write("Значение функции: ");
for (int i = 0; i < n; i++)
{
    term = Math.Pow(-1, i) * (double_fact(2 * i - 1) * Math.Pow(x, 2 * i + 1)) / (double_fact(2 * i) * (2 * i + 1));
    if (Math.Abs(term) < e)
        break;
    result += term;
    
}

Console.WriteLine(result);