Console.Write("Введите сумму для снятия: ");
int sum = 0;
bool sumIsGood = false;
while (!sumIsGood)
{
    try
    {
        sum = Convert.ToInt32(Console.ReadLine());
        if (sum % 100 != 0)
        {
            throw new Exception("Введена не кратная сумма, попробуйте еще раз:");
        }
        if (sum > 150000)
        {
            throw new Exception("Введена сумма больше 150.000 рублей");
        }
        sumIsGood = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Введенные данные некорректны, попробуйте еще раз:");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

int banknote5000 = 0, banknote2000 = 0, banknote1000 = 0, banknote500 = 0, banknote200 = 0, banknote100 = 0;

while (sum > 0)
{
    banknote5000 = sum / 5000;
    sum = sum - 5000 * banknote5000;

    banknote2000 = sum / 2000;
    sum = sum - 2000 * banknote2000;

    banknote1000 = sum / 1000;
    sum = sum - 1000 * banknote1000;

    banknote500 = sum / 500;
    sum = sum - 500 * banknote500;

    banknote200 = sum / 200;
    sum = sum - 200 * banknote200;

    banknote100 = sum / 100;
    sum = sum - 100 * banknote100;
}

if (banknote5000 > 0) {
    Console.WriteLine($"Купюр по 5000: {banknote5000} штук");
}
if (banknote2000 > 0) {
    Console.WriteLine($"Купюр по 2000: {banknote2000} штук");
}
if (banknote1000 > 0) {
    Console.WriteLine($"Купюр по 1000: {banknote1000} штук");
}
if (banknote500 > 0) {
    Console.WriteLine($"Купюр по 500: {banknote500} штук");
}
if (banknote200 > 0) {
    Console.WriteLine($"Купюр по 200: {banknote200} штук");
}
if (banknote100 > 0) {
    Console.WriteLine($"Купюр по 100: {banknote100} штук");
}