namespace E02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            string numberString = number.ToString();
            int sum = 0;
            for (int i = 0; i < numberString.Length; i++)
            {
                if (char.IsDigit(numberString[i]))
                {
                    sum += (numberString[i] - '0'); 
                }
            }
            Console.WriteLine(sum);
        }
    }
}
   
