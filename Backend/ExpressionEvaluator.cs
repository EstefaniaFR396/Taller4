
namespace Backend;

public static class ExpressionEvaluator
{
    public static double Evalute(string infix)
    {
        return EvalutePostfix(ToPostfix(infix));
    }

    private static System.Collections.Generic.List<string> ToPostfix(string infix)
    {
        var postfix = new System.Collections.Generic.List<string>();
        var stack = new System.Collections.Generic.Stack<string>();

        int i = 0;

        while (i < infix.Length)
        {
            char c = infix[i];

            if (char.IsWhiteSpace(c))
            {
                i++;
                continue;
            }

            // Read whole numbers and decimals
            if (char.IsDigit(c) || c == '.' || c == ',')
            {
                string number = "";

                while (i < infix.Length &&
                       (char.IsDigit(infix[i]) ||
                        infix[i] == '.' ||
                        infix[i] == ','))
                {
                    number += infix[i];
                    i++;
                }

                number = number.Replace(',', '.');

                if (!double.TryParse(
                    number,
                    System.Globalization.NumberStyles.AllowDecimalPoint,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out _))
                {
                    throw new System.ArgumentException(
                        "Numero decimal invalido: " + number);
                }

                postfix.Add(number);
                continue;
            }

            if (c == '(')
            {
                stack.Push(c.ToString());
            }
            else if (c == ')')
            {
                while (stack.Count > 0 && stack.Peek() != "(")
                {
                    postfix.Add(stack.Pop());
                }

                if (stack.Count == 0)
                {
                    throw new System.ArgumentException(
                        "Parentesis desbalanceados.");
                }

                stack.Pop();
            }
            else if (IsOperator(c.ToString()))
            {
                string op = c.ToString();

                while (stack.Count > 0 &&
                       stack.Peek() != "(" &&
                       (PriorityStack(stack.Peek()) > PriorityInfix(op) ||
                       (PriorityStack(stack.Peek()) == PriorityInfix(op) &&
                        op != "^")))
                {
                    postfix.Add(stack.Pop());
                }

                stack.Push(op);
            }
            else
            {
                throw new System.ArgumentException(
                    "Caracter no valido: " + c);
            }

            i++;
        }

        while (stack.Count > 0)
        {
            if (stack.Peek() == "(")
            {
                throw new System.ArgumentException(
                    "Parentesis desbalanceados.");
            }

            postfix.Add(stack.Pop());
        }

        return postfix;
    }

    private static int PriorityStack(string op)
    {
        return op switch
        {
            "^" => 3,
            "*" => 2,
            "/" => 2,
            "+" => 1,
            "-" => 1,
            _ => 0
        };
    }

    private static int PriorityInfix(string op)
    {
        return PriorityStack(op);
    }

    private static bool IsOperator(string op)
    {
        return op == "^" || op == "*" ||
               op == "/" || op == "+" || op == "-";
    }

    private static double EvalutePostfix(
        System.Collections.Generic.List<string> postfix)
    {
        var stack = new System.Collections.Generic.Stack<double>();

        foreach (string item in postfix)
        {
            if (IsOperator(item))
            {
                if (stack.Count < 2)
                {
                    throw new System.ArgumentException(
                        "Expresion matematica invalida.");
                }

                double ope2 = stack.Pop();
                double ope1 = stack.Pop();

                stack.Push(Calculate(ope1, ope2, item));
            }
            else
            {
                double number = double.Parse(
                    item,
                    System.Globalization.CultureInfo.InvariantCulture);

                stack.Push(number);
            }
        }

        if (stack.Count != 1)
        {
            throw new System.ArgumentException(
                "Expresion matematica invalida.");
        }

        return stack.Pop();
    }

    private static double Calculate(
        double ope1, double ope2, string op)
    {
        return op switch
        {
            "*" => ope1 * ope2,
            "/" => ope2 == 0
                ? throw new System.DivideByZeroException(
                    "No se puede dividir entre cero.")
                : ope1 / ope2,
            "+" => ope1 + ope2,
            "-" => ope1 - ope2,
            "^" => System.Math.Pow(ope1, ope2),
            _ => throw new System.ArgumentException(
                "Operador no valido.")
        };
    }
}
