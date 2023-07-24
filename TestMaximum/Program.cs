using TestMaximum;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Genreric Method & Classes");
        Console.WriteLine("Finding the maximum of three");
        Operation operation = new Operation();
        operation.FindMaxInteger(1, 2, 3);
        operation.FindMaxFloat(1.2f, 2.34f, 3.23f);
        operation.FindMaxString("First", "Second", "Third");
    }
}