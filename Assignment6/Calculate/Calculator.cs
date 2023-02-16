namespace Calculate;
public class Calculator
{
    public Calculator() { }
    public Calculator(Action<string> writeLine, Func<string?> readLine) =>
        (WriteLine, ReadLine) = (writeLine, readLine);
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static int Divide(int a, int b) => a / b;

    IReadOnlyDictionary<char, Func<int, int, int>> MathamaticalOperations { get; } = new Dictionary<char, Func<int, int, int>>()
    {
        {'+', Add },
        {'-', Subtract},
        {'*', Multiply},
        {'/', Divide }
    };
    
    public Action<string> WriteLine { get; set; } = Console.WriteLine;
    public Func<string?> ReadLine { get; set; } = Console.ReadLine;

    public bool TryCalculate(string calculation, out int result)
    {
        bool success = false;
        if (calculation.Split(' ') is [string operand1Text, [char @operator], string operand2Text]
            && int.TryParse(operand1Text, out int operand1)
            && int.TryParse(operand2Text, out int operand2))
        {
            result = MathamaticalOperations[@operator](operand1, operand2);
            success = true;
        }
        else result = 0;
        return success;
    }

}
