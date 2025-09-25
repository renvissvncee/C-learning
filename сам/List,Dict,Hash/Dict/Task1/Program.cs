// Подсчёт количества вхождений каждого слова в массиве
string[] words = { "apple", "banana", "apple", "orange", "banana" };
var dict = new Dictionary<string, int>();

foreach (var word in words)
{
    if (dict.ContainsKey(word))
        dict[word]++;
    else
        dict[word] = 1;
}

foreach (var pair in dict)
{
    Console.WriteLine($"Слово: {pair.Key}, Количество: {pair.Value}");
}

