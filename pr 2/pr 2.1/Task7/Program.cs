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
    int tempX = w / a;
    if (tempX == 0) return false;
    int tempY = (n / tempX) * tempX == n ? (n / tempX) : (n / tempX) + 1;
    return tempY * b <= h;
    // w / a = сколько поместиться целых штук по одной стороне
    // (n / (w / a))* (w/a) == n ? (n / (w / a)) : (n / (w / a)) + 1
    //  Math.Celling(n / (w/a)) * b = какую длину займет расположение
    // на другой стороне
    // если верхнее выражение меньше чем h, то поместиться 
} 

int i = 0;
int d = 0;
while (a * b * n <= w * h) {
    if (placementFlag(a, b, w, h, n) || placementFlag(b, a, w, h, n)) { d = i; }
    a += 2;
    b += 2;
    i++;
}

Console.WriteLine($"Ответ: d = {d}");