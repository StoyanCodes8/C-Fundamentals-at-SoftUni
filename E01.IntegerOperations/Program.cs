namespace E01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int 1 + int 2 = result
            // result / int3 = result2
            //result2 * int4 = result 3
            int[] numbers = new int[4];
            numbers[0] = int.Parse(Console.ReadLine());
            numbers[1] = int.Parse(Console.ReadLine());
            numbers[2] = int.Parse(Console.ReadLine());
            numbers[3] = int.Parse(Console.ReadLine());
            //calculations
            int result = numbers[0] + numbers[1];
            int result2 = result / numbers[2];
            int result3 = result2 * numbers[3];
            Console.WriteLine(result3);
        }
    }
}
