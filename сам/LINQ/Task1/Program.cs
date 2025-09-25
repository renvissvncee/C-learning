using System.Linq;
List<int> numbers = new List<int> { 3, 7, 2, 8, 5, 10, 1 };

Console.WriteLine(numbers.FirstOrDefault(n => n % 2 == 0));