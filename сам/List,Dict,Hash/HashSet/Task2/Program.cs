var set1 = new HashSet<int>
(Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray());

var set2 = new HashSet<int>
(Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray());

set1.IntersectWith(set2);

foreach (var item in set1)
{
    Console.Write(item + " ");
}