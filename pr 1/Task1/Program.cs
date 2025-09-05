/* using System.Reflection;
Console.WriteLine("Введите выражение (каждый символ с новой строки):");
double num1 = Convert.ToDouble(Console.ReadLine());
double result = num1;

double memory = 0;
bool memoryFlag = false;

string? operation = Console.ReadLine();
while (operation != "=")
{
    string? input = Console.ReadLine();
    double inputNum = 0;
    if (input != "MR")
    {
        inputNum = Convert.ToDouble(input);
    }
    else if (input == "MR" && memoryFlag == false)
    {
        Console.WriteLine("В памяти ничего нет");
        while (input == "MR")
        {
            input = Console.ReadLine();
        }
    }
    else
    {
        inputNum = memory;
    }

    switch (operation)
    {
        case "+":
            result = result + inputNum;
            Console.WriteLine($"Ответ: {result}");
            operation = Console.ReadLine();
            break;
        case "-":
            result = result - inputNum;
            Console.WriteLine($"Ответ: {result}");
            operation = Console.ReadLine();
            break;
        case "*":
            result = result * inputNum;
            Console.WriteLine($"Ответ: {result}");
            operation = Console.ReadLine();
            break;
        case "/":
            result = result / inputNum;
            Console.WriteLine($"Ответ: {result}");
            operation = Console.ReadLine();
            break;
        case "%":
            result = result * (inputNum / 100);
            Console.WriteLine($"Ответ: {result}");
            operation = Console.ReadLine();
            break;
        case "1/x":
            result = 1 / result;
            Console.WriteLine($"Ответ: {result}");
            operation = Console.ReadLine();
            break;
        case "x^2":
            result = result * result;
            Console.WriteLine($"Ответ: {result}");
            operation = Console.ReadLine();
            break;
        case "sqrt":
            result = Math.Sqrt(result);
            Console.WriteLine($"Ответ: {result}");
            operation = Console.ReadLine();
            break;
        case "M+":
            if (memoryFlag == false)
            {
                memory = result;
                memoryFlag = true;
            }
            else
            {
                result = result + memory;
            }
            operation = Console.ReadLine();
            break;
        case "M-":
            if (memoryFlag == false)
            {
                memory = result;
                memoryFlag = true;
            }
            else
            {
                result = memory - result;
            }
            operation = Console.ReadLine();
            break;

        default:
            Console.WriteLine("Некорректный ввод");
            operation = "=";
            break;
    }
}

 */