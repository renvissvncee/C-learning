var dict = new Dictionary<int, string>();

int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine()!.Split(' ');
    dict.Add(int.Parse(input[0]), input[1]);
}

var new_dict = new Dictionary<string, int>();

foreach (var item in dict)
{
    new_dict.Add(item.Value, item.Key);
}

foreach (var item in dict)
{
    Console.WriteLine($"{item.Key}, {item.Value}");
}

foreach (var item in new_dict)
{
    Console.WriteLine($"{item.Key}, {item.Value}");
}



