using TestMaximum;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Genreric Method & Classes");
        Console.WriteLine("Finding the maximum of three");
        Operation operation = new Operation();
        operation.FindMaxInteger(1, 2, 3);
    }
}