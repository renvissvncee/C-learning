Stack<object> stack = new Stack<object>();

Console.Write("Введите число: ");
string? input = Console.ReadLine();

bool numFlag = true; // Флаг на проверку, что ждет калькулятор: число или операцию

double result = Convert.ToDouble(input);

double memory = 0;


static void PrintStack<T>(Stack<T> stack)
{
    // Используем массив для временного хранения элементов
    T[] items = stack.ToArray(); // ToArray возвращает элементы в порядке от верхушки к низу
    Console.WriteLine("Содержимое стека:");
    foreach (T item in items)
    {
        Console.WriteLine(item);
    }
}

// Продолжение (основная часть)
while (input != "=")
{
    if (stack.Count == 3)
    {
        double num1, num2;
        string? operation;
        num2 = Convert.ToDouble(stack.Pop());
        operation = Convert.ToString(stack.Pop());
        num1 = Convert.ToDouble(stack.Pop());
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                // Проверка деления на ноль
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Делить на ноль нельзя!");
                }
                break;
            case "%":
                result = num1 * (num2 / 100);
                break;

            default:
                Console.WriteLine("Что то не так");
                break;
        }
        if (!double.IsInfinity(result))
        {
            stack.Push(result);
            Console.WriteLine($"Ответ: {result}");
            numFlag = false;
            Console.Write("Введите операцию: ");
            input = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Слишком большое число. Начните сначала");
            Console.Write("Введите число: ");
            numFlag = true;
            stack.Clear();
            input = Console.ReadLine();
        }
    }

    // Калькулятор ждет число
    if (numFlag)
    {
        if (input == "MR")
        {
            stack.Push(memory);
            numFlag = false;
        }
        else
        {
            try
            {
                stack.Push(Convert.ToDouble(input)); // конвертируем в double для проверки
                // что пользователь действительно ввел число
                numFlag = false;

                if (!(stack.Count == 3))
                { 
                    Console.Write("Введите операцию: ");
                    input = Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("Введите число!");
                input = Console.ReadLine();
            }
        }
    }
    // Калькулятор ждет знак
    else
    {
        if (input == "+" || input == "-" || input == "*" || input == "/" || input == "%")
        {
            stack.Push(input);
            numFlag = true;
        }
        else if (input == "1/x")
        {
            // проверка деления на ноль
            if (result != 0)
            {
                result = 1 / Convert.ToDouble(stack.Pop());
                stack.Push(result);
                Console.WriteLine($"Ответ: {result}");
            }
            else
            {
                Console.WriteLine("Делить на ноль нельзя!");
            }
        }
        else if (input == "x^2")
        {
            double tempNum = Convert.ToDouble(stack.Pop());
            result = tempNum * tempNum;
            stack.Push(result);
            Console.WriteLine($"Ответ: {result}");
        }
        else if (input == "sqrt")
        {
            result = Math.Sqrt(Convert.ToDouble(stack.Pop()));
            stack.Push(result);
            Console.WriteLine($"Ответ: {result}");
        }
        else if (input == "M+")
        {
            memory = memory + result;
        }
        else if (input == "M-")
        {
            memory = memory - result;
        }
        else
        {
            Console.WriteLine("Неверный ввод!");
        }

        if (numFlag)
        {
            Console.Write("Введите число: ");
            input = Console.ReadLine();
        }
        else
        {
            Console.Write("Введите операцию: ");
            input = Console.ReadLine();
        }
    }
} 