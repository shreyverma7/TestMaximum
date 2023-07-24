using TestMaximum;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Finding the maximum of three");
        GenericClass<int> operation = new GenericClass<int>();
        operation.FindMax(1, 2, 3);
        
    }
}