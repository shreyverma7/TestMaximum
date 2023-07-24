using TestMaximum;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Finding the maximum of three");
        GenericClass<int> operation = new GenericClass<int>();
        operation.FindMax(1, 2, 3);
        GenericClass<float> operation1 = new GenericClass<float>();
        operation1.FindMax(2.5f, 9.9f, 11.2f);
        GenericClass<string> operation2 = new GenericClass<string>();
        operation2.FindMax("Shrey", "is", "good");

    }
}