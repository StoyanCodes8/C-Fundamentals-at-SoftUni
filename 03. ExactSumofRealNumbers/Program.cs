namespace _03._ExactSumofRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int cycleLength = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for(int i = 1; i <= cycleLength; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
