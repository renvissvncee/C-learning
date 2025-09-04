Console.WriteLine("Введите 1 число:");
string? num1 = Console.ReadLine();
Console.WriteLine("Введите операцию:");
string? operation = Console.ReadLine();
Console.WriteLine("Введите 2 число:");
string? num2 = Console.ReadLine();
Console.WriteLine("Ответ:");

Convert.ToDouble(num1);
Convert.ToDouble(num2);

switch (operation)
{
    case "+":
        Console.WriteLine(num1 + num2);
        break;

    default:
        Console.WriteLine("Некорректный ввод");
        break;
}
