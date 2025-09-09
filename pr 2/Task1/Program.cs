Console.Write("Введите 'x': ");
double x = x = Convert.ToDouble(Console.ReadLine());
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

double pow(double x, int s)
{
    double res = x;
    if (s == 0)
        return 1;
    for (int i = 1; i < s; i++)
        {
            res = res * x;
        }
    return res;
}


double result = 0;
double term = 0;
Console.Write("Значение функции: ");
for (int i = 0; i < n; i++)
{
    term = pow(-1, i) * (double_fact(2 * i - 1) * pow(x, 2 * i + 1)) / (double_fact(2 * i) * (2 * i + 1));
    if (Math.Abs(term) >= e)
        result += term;
}

// Узнаем сколько знаков после запятой нужно
int precision = 0;
string e_ch = Convert.ToString(e);
e_ch = e_ch.Substring(2, e_ch.Length - 2);
int j = 0;
char c = e_ch[j];
while (c != '1')
{
    precision += 1;
    j++;
    c = e_ch[j];
}

Console.Write(Convert.ToString(result).Substring(0,));