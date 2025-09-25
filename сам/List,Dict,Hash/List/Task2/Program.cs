var list = new List<int>();

string[] elements = Console.ReadLine().Split(' ');

foreach (string item in elements)
{
    list.Add(Convert.ToInt32(item));
}

var new_list = new List<int>();
int sum = 0;
for (int i = 0; i < list.Count; i++)
{
    for (int j = 0; j < list.Count; j++)
    {
        if (list[i] == list[j])
        {
            sum += 1;
        }
    }

    if (sum == 1)
    {
        new_list.Add(list[i]);
    }
    sum = 0;
}

list = new_list;

foreach (int item in list)
{
    Console.WriteLine(item);
}
