using System.Dynamic;

int[] array = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

var set = new HashSet<int>(array);

foreach (var item in set)
{
    Console.Write(item + " ");
}
