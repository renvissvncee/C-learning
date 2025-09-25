Console.Write("Введите длину списка: ");
int c = Convert.ToInt32(Console.ReadLine());
var list = new List<int>(c);

for (int i = 0; i < c; i++) {
    Console.Write($"Введите {i+1}-ый элемент списка: ");
    list.Add(Convert.ToInt32(Console.ReadLine()));
}

int sum = 0;

for (int i = 0; i < c; i++)
{
    sum += list[i];
}

Console.WriteLine($"{sum}, {sum / list.Count}");