int amountOfWater = 0;
int amountOfMilk = 0;

int cupOfAmericano = 0;
int cupOfLatte = 0;

int price = 0;

Console.Write("Введите кол-во воды в мл: ");
amountOfWater = Int32.Parse(Console.ReadLine()!);

Console.Write("Введите кол-во молока в мл: ");
amountOfMilk = Int32.Parse(Console.ReadLine()!);


char c = ' ';
do
{
    Console.Write("Выберите напиток (1 - американо, 2 - латте): ");
    c = Char.Parse(Console.ReadLine()!);

    if (c == '1' && amountOfWater >= 300)
    {
        price += 150;
        amountOfWater -= 300;
        cupOfAmericano++;
        Console.WriteLine("Ваш напиток готов.");
    }
    else if (c == '1' && amountOfWater < 300)
    {
        Console.WriteLine("Не хватает воды");
    }
    else if (c == '2' && amountOfWater >= 30 && amountOfMilk >= 270)
    {
        price += 170;
        amountOfWater -= 30;
        amountOfMilk -= 270;
        cupOfLatte++;
        Console.WriteLine("Ваш напиток готов.");
    }
    else
    {
        if (amountOfMilk < 270)
        {
            Console.WriteLine("Не хватает молока");
        }
        if (amountOfWater < 30)
        {
            Console.WriteLine("Не хватает воды");
        }
    }
} while (amountOfWater >= 300 || (amountOfWater >= 30 && amountOfMilk >= 270));

// Отчет
Console.WriteLine("*Отчет*");
Console.WriteLine("Ингридиентов осталось: ");
Console.WriteLine($"     Вода: {amountOfWater} мл");
Console.WriteLine($"     Молоко: {amountOfMilk} мл");
Console.WriteLine($"Кружек американо приготовлено: {cupOfAmericano} шт");
Console.WriteLine($"Кружек латте приготовлено: {cupOfLatte} шт");
Console.WriteLine($"Итого: {price} руб");

