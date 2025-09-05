Stack<object> stack = new Stack<object>();

string? input = Console.ReadLine();

bool numFlag = true;

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

// "Начальная стадия"
while (numFlag)
{
    try
    {
        stack.Push(Convert.ToDouble(input));
        numFlag = false;
    }
    catch
    {
        Console.WriteLine("Введите число!");
        input = Console.ReadLine();
    }
}
input = Console.ReadLine();

// Продолжение
while (input != "=")
{
    if (stack.Count() == 3)
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
                result = num1 / num2;
                break;
            case "%":
                result = num1 * (num2 / 100);
                break;

            default:
                Console.WriteLine("Что то не так");
                break;
        }
        stack.Push(result);
        Console.WriteLine($"Ответ: {result}");
        numFlag = false;
        input = Console.ReadLine();
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
            result = 1 / Convert.ToDouble(stack.Pop());
            stack.Push(result);
            Console.WriteLine($"Ответ: {result}");
            numFlag = false;
        }
        else if (input == "x^2")
        {
            double tempNum = Convert.ToDouble(stack.Pop());
            result = tempNum * tempNum;
            stack.Push(result);
            Console.WriteLine($"Ответ: {result}");
            numFlag = false;
        }
        else if (input == "sqrt")
        {
            result = Math.Sqrt(Convert.ToDouble(stack.Pop()));
            stack.Push(result);
            Console.WriteLine($"Ответ: {result}");
            numFlag = false;
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
        //Console.WriteLine("Поседний ");Console.WriteLine(Convert.ToString(stack.Peek()));
        input = Console.ReadLine();
    }
    //PrintStack(stack);
} 