public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap gia tri dong USD: ");
        int USD = int.Parse(Console.ReadLine());
        int VND = USD * 23000;
        Console.WriteLine("Gia tri dong VND: " + VND);
    }
}