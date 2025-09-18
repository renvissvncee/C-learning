using System.Diagnostics.CodeAnalysis;
int left = 1;
int right = 63;
string? answer;
for (int i = 1; i < 7; i++)
{
    Console.Write($"Ваше число больше {(left + right) / 2}? (1-да; 0-нет) ");
    do
    {
        answer = Console.ReadLine();
    } while (answer != "0" && answer != "1");

    left = (answer == "1") ? ((left + right) / 2) + 1 : left;
    right = (answer == "1") ? right : (left + right) / 2;
}

Console.WriteLine($"Ответ: {right}");

