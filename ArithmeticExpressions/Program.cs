using System;

class Solution
{
    static string EvaluateExpression(string expression)
    {
        if (expression == null || expression == "")
            return "Error:InvalidExpression";

        string[] parts = expression.Split(' ');

        if (parts.Length != 3)
            return "Error:InvalidExpression";
        string firstNumber = parts[0];
        string operatorSymbol = parts[1];
        string secondNumber = parts[2];

        int a, b;

        try
        {
            a = Convert.ToInt32(firstNumber);
            b = Convert.ToInt32(secondNumber);
        }
        catch
        {
            return "Error:InvalidNumber";
        }

        if (operatorSymbol == "+")
            return (a + b).ToString();

        if (operatorSymbol == "-")
            return (a - b).ToString();

        if (operatorSymbol == "*")
            return (a * b).ToString();

        if (operatorSymbol == "/")
        {
            if (b == 0)
                return "Error:DivideByZero";

            return (a / b).ToString();
        }

        return "Error:UnknownOperator";
    }

    static void Main()
    {
        Console.WriteLine(EvaluateExpression("10 + 5"));
        Console.WriteLine(EvaluateExpression("10 / 0"));
        Console.WriteLine(EvaluateExpression("a + 5"));
        Console.WriteLine(EvaluateExpression("10 & 5"));
        Console.WriteLine(EvaluateExpression("10 5"));
    }
}

