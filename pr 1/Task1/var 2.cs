/* Stack<double> stack = new Stack<double>();
string? input = Console.ReadLine();
bool numFlag = true;

bool memoryFlag = false;
double memory = 0;

double inputNum = 0;

double result = 0;

// "Начальная стадия"
while (!numFlag)
{
    try
    {
        inputNum = Convert.ToDouble(input);
        numFlag = false;
        input = Console.ReadLine();
    }
    catch
    {
        Console.WriteLine("Введите число!");
        input = Console.ReadLine();
    }
}
result = inputNum;

// Продолжение
while (input != "=")
{
    if (numFlag)
    {
        try
        {
            inputNum = Convert.ToDouble(input);
            numFlag = false;
            input = Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Введите число!");
            input = Console.ReadLine();
        }
    }
    else
    {
        switch (input)
        {
            case "+":
                result = result + inputNum;
                numFlag = true;
                input = Console.ReadLine();
                break;
            case "-":
                result = result - inputNum;
                Console.WriteLine($"Ответ: {result}");
                numFlag = true;
                input = Console.ReadLine();
                break;
            case "*":
                result = result * inputNum;
                Console.WriteLine($"Ответ: {result}");
                numFlag = true;
                input = Console.ReadLine();
                break;
            case "/":
                result = result / inputNum;
                Console.WriteLine($"Ответ: {result}");
                numFlag = true;
                input = Console.ReadLine();
                break;
            case "%":
                result = result * (inputNum / 100);
                Console.WriteLine($"Ответ: {result}");
                numFlag = true;
                input = Console.ReadLine();
                break;
            case "1/x":
                result = 1 / result;
                Console.WriteLine($"Ответ: {result}");
                numFlag = true;
                input = Console.ReadLine();
                break;
            case "x^2":
                result = result * result;
                Console.WriteLine($"Ответ: {result}");
                numFlag = true;
                input = Console.ReadLine();
                break;
            case "sqrt":
                result = Math.Sqrt(result);
                Console.WriteLine($"Ответ: {result}");
                numFlag = true;
                input = Console.ReadLine();
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
                input = Console.ReadLine();
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
                input = Console.ReadLine();
                break;

            default:
                Console.WriteLine("Некорректный ввод");
                input = Console.ReadLine();
                break;
        }
    }
}
 */