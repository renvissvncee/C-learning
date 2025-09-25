List<string> words = new List<string> { "cat", "dog", "apple", "car", "zebra" };
foreach (var word in words.Where(n => n[0] == 'c'))
{
    Console.WriteLine(word);
}
