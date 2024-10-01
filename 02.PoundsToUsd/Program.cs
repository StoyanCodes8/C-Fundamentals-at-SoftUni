namespace _02.PoundsToUsd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double britPound = double.Parse(Console.ReadLine());
            double changeRate = 1.31f;
            double usd = britPound * changeRate;
            Console.WriteLine($"{usd:F3}");
        }
    }
}
