Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите w: ");
int w = int.Parse(Console.ReadLine()!);

Console.Write("Введите h: ");
int h = int.Parse(Console.ReadLine()!);

bool placementFlag(int a, int b, int w, int h, int n)
{
    Math.Ceiling(n / (w / a)) <= h
    return (a * n <= w && b * <= h) || (a <= h && b <= w);
}