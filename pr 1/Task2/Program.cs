Console.Write("Введите номер дня недели, с которого начинается месяц (1-пн, ... 7-вс): ");
int dayOfThe_Week = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите день месяца: ");
int dayOfThe_Month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("-----Проверяем выходной ли день-----");

if ((dayOfThe_Month >= 1 && dayOfThe_Month <= 5) || (dayOfThe_Month >= 8 && dayOfThe_Month <= 10))
{
    Console.WriteLine("Выходной день");
}
else
{
    if ((((dayOfThe_Month % 7) + (dayOfThe_Week - 1)) % 7) > 5)
    {
        Console.WriteLine("Выходной день");
    }
    else
    { 
        Console.WriteLine("Не выходной день");
    }
}



