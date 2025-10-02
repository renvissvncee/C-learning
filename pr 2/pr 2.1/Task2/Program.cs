Console.Write("Введите номер билета: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(((n / 100000) + ((n / 10000) % 10) + ((n / 1000) % 10))
 == (((n / 100) % 10) + ((n / 10) % 10) + (n % 10)));

