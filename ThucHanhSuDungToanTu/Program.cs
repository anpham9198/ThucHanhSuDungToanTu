internal class Program
{
    private static void Main(string[] args)
    {
        float width;
        float length;

        Console.Write("Enter width: ");
        width = float.Parse(Console.ReadLine());
        Console.Write("Enter length: ");
        length = float.Parse(Console.ReadLine());
        
        float area = width * length;
        Console.WriteLine("Area is: " + area);

        Console.ReadKey();
    }
}