using System;

class Solution
{
    public static string EvaluateExpression(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            return "Error:InvalidExpression";

        string[] parts = expression.Split(' ');

        if (parts.Length != 3)
            return "Error:InvalidExpression";

        int a, b;
        try
        {
            a = Convert.ToInt32(parts[0]);
            b = Convert.ToInt32(parts[2]);
        }
        catch
        {
            return "Error:InvalidNumber";
        }

        string op = parts[1];
        switch (op)
        {
            case "+":
                return (a + b).ToString();

            case "-":
                return (a - b).ToString();

            case "*":
                return (a * b).ToString();

            case "/":
                if (b == 0)
                    return "Error:DivideByZero";
                return (a / b).ToString();

            default:
                return "Error:UnknownOperator";
        }
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
